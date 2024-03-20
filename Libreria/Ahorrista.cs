namespace Libreria;

public class Ahorrista : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo += monto * 0.5;
            cliente.cuenta.SaldoCuenta += monto * 0.5;
            System.Console.WriteLine("Estado ahorrista");
        }
    }
    public void Debitar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo -= monto * 0.5;
            cliente.cuenta.SaldoCuenta -= monto * 0.5;
        }
    }    
    public bool PuedeUsarme(Cliente cliente) => cliente.Saldo > 50000;
}
