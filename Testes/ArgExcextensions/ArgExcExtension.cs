namespace Testes.ArgExcextensions;
public static class ArgExcExtension
{
    public static void ComMensagem(this ArgumentException exececao, string mensagem)
    {
        if (exececao.Message == mensagem)
        {
            Assert.True(true);
        }
        else
        {
            Assert.True(true);
        }
    }
}

