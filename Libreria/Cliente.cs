namespace Libreria;

public class Cliente
{
    public string Nombre { get; set; } 
    public string Apellido { get; set; } 
    public double Saldo { get; set; }
    public Cuenta cuenta;
    public Cliente(string nombre, string apellido, double saldo, Cuenta cuenta)
    {
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldo + cuenta.SaldoCuenta;
        this.cuenta = cuenta;
    }
    public void Debitar(double cantidad)
    {
        if (ValidarDebito(cantidad))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            Saldo -= cantidad * 0.8;
            cuenta.SaldoCuenta -= cantidad * 0.2;
        }
    }
    public void Acreditar(double cantidad) 
    {
        Saldo += cantidad * 0.8;
        cuenta.SaldoCuenta += cantidad * 0.2;
    }
    public bool ValidarDebito(double cantidad) => Saldo - cantidad < 0;
}