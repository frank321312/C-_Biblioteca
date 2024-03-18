namespace Libreria;

public class Cuenta
{
    public double SaldoCuenta { get; set; }
    public Guid Cbu = Guid.NewGuid();
    public Cliente cliente;
    public Cuenta(double saldoCuenta, Cliente cliente)
    {
        SaldoCuenta = saldoCuenta;
        this.cliente = cliente;
    }
    public void Debitar(double cantidad)
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
    public void Acreditar(double cantidad) 
    {
        cliente.Saldo += cantidad * 0.8;
        SaldoCuenta += cantidad * 0.2;
    }
}