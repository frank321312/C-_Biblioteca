namespace Libreria;

public class Cauto : ICliente
{
    public void EstadoCliente(double efectivo)
    {
        if (efectivo >= 10000 && efectivo <= 50000)
        {
            System.Console.WriteLine("Tiene entre 10.000 y 50.000");
        }
    }
}
