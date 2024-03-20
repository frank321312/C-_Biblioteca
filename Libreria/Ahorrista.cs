namespace Libreria;

public class Ahorrista : ICliente
{
    public void EstadoCliente(double efectivo)
    {
        if (efectivo > 50000)
        {
            System.Console.WriteLine("Tenes mas de 50.000");
        }
    }
}
