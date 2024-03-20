namespace Libreria;

public class Cliente
{
    public string Nombre { get; set; } 
    public string Apellido { get; set; } 
    public double Saldo { get; set; }
    public Cuenta cuenta;
    private ICliente oCliente;
    public Cliente(string nombre, string apellido, double saldo, Cuenta cuenta)
    {
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldo + cuenta.SaldoCuenta;
        this.cuenta = cuenta;
        // Valor por defecto
        oCliente = new Emergencia();
    }
    public void EstadoEmergencia()
    {
        oCliente = new Emergencia();
    }
    public ICliente EstadoCauto() 
    {
        oCliente = new Cauto();
        return oCliente;
    }
    public void EstadoAhorrista() 
    {
        oCliente = new Ahorrista();
    }
    public void EstadoCliente()
    {
        oCliente.EstadoCliente(Saldo);
    }
    public void DebitarEfectivo(double cantidad)
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
    public void AcreditarEfectivo(double cantidad) 
    {
        Saldo += cantidad * 0.8;
        cuenta.SaldoCuenta += cantidad * 0.2;
    }
    public bool ValidarDebito(double cantidad) => Saldo - cantidad < 0;
}