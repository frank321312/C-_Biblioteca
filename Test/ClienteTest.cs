using Xunit;
using Libreria;

namespace Test;

public class ClienteTest
{
    [Fact]
    public void Cliente()
    {
        var cuenta = new Cuenta(0);
        var cliente = new Cliente("Hijitus", "Apellido", 3000, cuenta);

        System.Console.WriteLine(cliente);
    }
}
