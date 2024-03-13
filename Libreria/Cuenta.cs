namespace Libreria;

public class Cuenta
{
    public double SaldoCuenta { get; set; }
    public Guid Cbu = Guid.NewGuid();
    public Cuenta(double saldoCuenta)
    {
        SaldoCuenta = saldoCuenta;
    }
    public void Debitar(Cliente cliente, double cantidad)
    {
        if (cliente.ValidarDebito(cantidad))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            SaldoCuenta -= cantidad * 0.2;
            cliente.Saldo -= cantidad * 0.8;
        }
    }
    public void Acreditar(Cliente cliente, double cantidad) 
    {
        cliente.Saldo += cantidad * 0.8;
        SaldoCuenta += cantidad * 0.2;
    }
}