using System.Text;

namespace Day3_Static;

public static class SecurityHelper
{
    //Şifreye ihtiyacımız var
    //PasswordHash
    //PasswordSalt

    //Hash için kullanılabilecek bazı algoritmalar... HmacSha512, HmacSha256

    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512()) //using nesnesi programı yorar
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
