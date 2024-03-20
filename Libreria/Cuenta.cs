namespace Libreria;

public class Cuenta
{
    public double SaldoCuenta { get; set; }
    public Guid Cbu = Guid.NewGuid();
    public Cuenta(double saldoCuenta)
    {
        SaldoCuenta = saldoCuenta;
    }
    public void Debitar(Cliente cliente, double monto)
    {
        if (cliente.ValidarDebito(monto))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            SaldoCuenta -= monto * 0.2;
            cliente.Saldo -= monto * 0.8;
        }
    }
    public void Acreditar(Cliente cliente, double monto) 
    {
        cliente.Saldo += monto * 0.8;
        SaldoCuenta += monto * 0.2;
    }
}