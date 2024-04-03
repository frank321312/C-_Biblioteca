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
            cliente.DebitarEfectivo(monto);
        }
    }
    public void Acreditar(Cliente cliente, double monto) 
    {
        cliente.AcreditarEfectivo(monto);
    }
    public double DevolverSaldo() => SaldoCuenta;
}