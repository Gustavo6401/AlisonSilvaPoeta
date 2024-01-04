using AlisonSilvaPoeta.Services.Cryptograph;

namespace AlisonSilvaUnitTest.Criptografia;

[TestClass]
public class Sha512Test
{
    private Sha512 Sha512;

    public Sha512Test()
    {
        Sha512 = new Sha512();
    }
    [TestMethod]
    public async Task Criptografar()
    {
        string nome = "Gustavo";

        string? resultado = Sha512.Criptografar(nome);

        Assert.AreEqual(resultado.Length, 88);
        Assert.AreEqual(resultado, "2Zh9WTQAvtFad4u8jP9CF16h+1g6Px5caumIIXvC0JayCNFUhC4WnL5a63Ur+xnHwB/FFQMTOKIIY7TRiwP4WA==");
    }
}
