namespace Libreria;

public class Emergencia : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
<<<<<<< HEAD
        if (PuedeUsarme(cliente))
        {
            cliente.Saldo += monto;
            System.Console.WriteLine("Estado emergencia");
        } else {
            System.Console.WriteLine("No puede usar este estado");
        }
=======
        cliente.Saldo += monto;
>>>>>>> 9c4d77730059eeed78476024e6c82b6f050f2219
    }
    public void Debitar(Cliente cliente, double monto)
    {
        cliente.cuenta.SaldoCuenta -= monto;
        if (cliente.cuenta.SaldoCuenta < 0)
        {
            cliente.Saldo += cliente.cuenta.SaldoCuenta;
            cliente.cuenta.SaldoCuenta = 0;
        }
    }
<<<<<<< HEAD
    public bool PuedeUsarme(Cliente cliente) => cliente.Saldo < 10000;
=======
    public bool SePuedeAplicar(Cliente cliente) => cliente.Saldo < 10000;
>>>>>>> 9c4d77730059eeed78476024e6c82b6f050f2219
}
