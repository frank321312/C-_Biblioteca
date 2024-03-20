namespace Libreria;

public class Cauto : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo += monto * 0.8;
            cliente.cuenta.SaldoCuenta += monto * 0.2;
            System.Console.WriteLine("Estado cauto");
        }
    }
    public void Debitar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo -= monto * 0.8;
            cliente.cuenta.SaldoCuenta -= monto * 0.2;
        }
    }    
    public bool PuedeUsarme(Cliente cliente) => cliente.Saldo >= 10000 && cliente.Saldo <= 50000;
}
