namespace Libreria;

public class Emergencia : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Saldo += monto;
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
    public bool SePuedeAplicar(Cliente cliente) => cliente.Saldo < 10000;
}
