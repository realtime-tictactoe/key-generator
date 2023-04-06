using System.Security.Cryptography;

var key = AesKeyGen.GenerateKey();
Console.WriteLine(key);

public static class AesKeyGen
{
    public static string GenerateKey()
    {
        using (var aes = Aes.Create())
        {
            aes.GenerateKey();
            return Convert.ToHexString(aes.Key);
        }
    }
}