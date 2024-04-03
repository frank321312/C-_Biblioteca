namespace Libreria;

public class Emergencia : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo += monto;
            System.Console.WriteLine("Estado emergencia");
        } else {
            System.Console.WriteLine("No puede usar este estado");
        }
    }
    public void Debitar(Cliente cliente, double monto)
    {
        if (PuedeUsarme(cliente))
        {
            cliente.cuenta.SaldoCuenta -= monto;
        }
    }
    public bool PuedeUsarme(Cliente cliente) => cliente.Saldo < 10000;
}
