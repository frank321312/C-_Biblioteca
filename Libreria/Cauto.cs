namespace Libreria;

public class Cauto : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Saldo += monto * 0.8;
        cliente.cuenta.SaldoCuenta += monto * 0.2;   
    }
    public void Debitar(Cliente cliente, double monto)
    {
        cliente.Saldo -= monto * 0.8;
        cliente.cuenta.SaldoCuenta -= monto * 0.2;            
        if (cliente.Saldo < 0)
        {
            cliente.cuenta.SaldoCuenta += cliente.Saldo;
            cliente.Saldo = 0;
        }
        if (cliente.cuenta.SaldoCuenta < 0)
        {
            cliente.Saldo += cliente.cuenta.SaldoCuenta;
            cliente.cuenta.SaldoCuenta = 0;
        }
    }    
    public bool SePuedeAplicar(Cliente cliente) => cliente.Saldo >= 10000 && cliente.Saldo <= 50000;
}
