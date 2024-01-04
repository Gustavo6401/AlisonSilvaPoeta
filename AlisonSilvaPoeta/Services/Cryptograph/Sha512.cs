using System.Security.Cryptography;
using System.Text;

namespace AlisonSilvaPoeta.Services.Cryptograph;

public class Sha512
{
    public string? Criptografar(string texto)
    {
        SHA512 sha512 = SHA512.Create();

        byte[] textoBytes = Encoding.UTF8.GetBytes(texto);
        byte[] criptografiaBytes = sha512.ComputeHash(textoBytes);

        return Convert.ToBase64String(criptografiaBytes);
    }
}
