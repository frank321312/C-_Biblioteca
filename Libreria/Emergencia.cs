namespace Libreria;

public class Emergencia : ICliente
{
    public void EstadoCliente(double efectivo)
    {
        if (efectivo < 10000)
        {
            System.Console.WriteLine("Tenes menos 10.000 peso en efectivo");
        }
    }
}
