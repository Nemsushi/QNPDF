using System.IO;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using System;

internal class Encryption
{
    // Ma hoa PDF
    public static void EncryptPDF(string pdfFilePath, string pemFilePath)
    {
        // Doc file
        byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);
        byte[] encryptedBytes;

        // Tao key AES & key IV
        using (var aes = Aes.Create())
        {
            aes.GenerateKey();
            byte[] symmetricKey = aes.Key;
            byte[] iv = aes.IV;

            // Ma hoa PDF bang key AES & key IV
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(pdfBytes, 0, pdfBytes.Length);
                    cryptoStream.FlushFinalBlock();
                }

                byte[] encryptedPDF = memoryStream.ToArray();

                // Ma hoa key AES bang RSA
                using (var rsa = GetRSAProviderFromPemFile(pemFilePath))
                {
                    byte[] encryptedKey = rsa.Encrypt(symmetricKey, RSAEncryptionPadding.Pkcs1);

                    // Key final = key RSA + key AES + key IV + file PDF
                    byte[] combinedBytes = new byte[encryptedKey.Length + iv.Length + encryptedPDF.Length];
                    Buffer.BlockCopy(encryptedKey, 0, combinedBytes, 0, encryptedKey.Length);
                    Buffer.BlockCopy(iv, 0, combinedBytes, encryptedKey.Length, iv.Length);
                    Buffer.BlockCopy(encryptedPDF, 0, combinedBytes, encryptedKey.Length + iv.Length, encryptedPDF.Length);

                    encryptedBytes = combinedBytes;
                }
            }
        }

        // Luu PDF
        string encryptedFilePath = Path.Combine(Path.GetDirectoryName(pdfFilePath), Path.GetFileNameWithoutExtension(pdfFilePath) + "_MaHoa.pdf");
        File.WriteAllBytes(encryptedFilePath, encryptedBytes);
    }

    // Giai ma PDF
    public static void DecryptPDF(string encryptedFilePath, string pemFilePath)
    {
        // Doc PDF
        byte[] encryptedBytes = File.ReadAllBytes(encryptedFilePath);
        byte[] decryptedBytes;

        using (var rsa = GetRSAProviderFromPemFile(pemFilePath))
        {
            int encryptedKeyLength = rsa.KeySize / 8;
            byte[] encryptedKey = new byte[encryptedKeyLength];
            byte[] iv = new byte[16]; // key IV = 16 byte
            byte[] encryptedPDF = new byte[encryptedBytes.Length - encryptedKeyLength - iv.Length];

            // Tach key final thanh key RSA + key AES + key IV + file PDF
            Buffer.BlockCopy(encryptedBytes, 0, encryptedKey, 0, encryptedKeyLength);
            Buffer.BlockCopy(encryptedBytes, encryptedKeyLength, iv, 0, iv.Length);
            Buffer.BlockCopy(encryptedBytes, encryptedKeyLength + iv.Length, encryptedPDF, 0, encryptedPDF.Length);

            // Giai ma key AES bang RSA
            byte[] symmetricKey = rsa.Decrypt(encryptedKey, RSAEncryptionPadding.Pkcs1);

            using (var aes = Aes.Create())
            {
                aes.Key = symmetricKey;
                aes.IV = iv;

                // Giai ma PDF bang key AES + key IV
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedPDF, 0, encryptedPDF.Length);
                        cryptoStream.FlushFinalBlock();
                    }

                    decryptedBytes = memoryStream.ToArray();
                }
            }
        }

        // Luu PDF
        string decryptedFilePath = Path.Combine(Path.GetDirectoryName(encryptedFilePath), Path.GetFileNameWithoutExtension(encryptedFilePath) + "_GiaiMa.pdf");
        File.WriteAllBytes(decryptedFilePath, decryptedBytes);
    }

    // Tao file .pem (luu key RSA)
    public static void GeneratePEMKey(string pemFilePath)
    {
        using (RSA rsa = RSA.Create())
        {
            string privateKey = ExportPrivateKeyToPEM(rsa.ExportParameters(true));
            File.WriteAllText(pemFilePath, privateKey);
        }
    }

    //Doc key RSA tu file .pem
    private static RSA GetRSAProviderFromPemFile(string pemFilePath)
    {
        string pemContents = File.ReadAllText(pemFilePath);
        var pemReader = new PemReader(new StringReader(pemContents));
        var keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
        var rsaParameters = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair.Private);

        var rsaProvider = RSA.Create();
        rsaProvider.ImportParameters(rsaParameters);

        return rsaProvider;
    }

    //Tao file .pem bang key RSA
    private static string ExportPrivateKeyToPEM(RSAParameters privateKey)
    {
        var keyPair = DotNetUtilities.GetRsaKeyPair(privateKey);
        var stringWriter = new StringWriter();
        var pemWriter = new PemWriter(stringWriter);
        pemWriter.WriteObject(keyPair.Private);
        pemWriter.Writer.Flush();

        return stringWriter.ToString();
    }
}
