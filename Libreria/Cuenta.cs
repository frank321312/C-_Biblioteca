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
            SaldoCuenta -= monto;
        }
    }
    public void Acreditar(Cliente cliente, double monto) 
    {
        SaldoCuenta += monto;
    }
    public double DevolverSaldo() => SaldoCuenta;
}