namespace Libreria;

public class Cliente
{
    public string Nombre { get; set; } 
    public string Apellido { get; set; } 
    public double Saldo { get; set; }
    public Cuenta cuenta;
    public IEstado _estado;
    public Cliente(string nombre, string apellido, double saldo, Cuenta cuenta)
    {
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldo + cuenta.SaldoCuenta;
        this.cuenta = cuenta;
        _estado = new Emergencia();
    }
    public void DebitarEfectivo(double monto)
    {
        if (ValidarDebito(monto))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            _estado.ControlarEstado(this);
            _estado.Debitar(this, monto);
        }
    }
    public void AcreditarEfectivo(double monto) 
    {
        _estado.ControlarEstado(this);
        _estado.Acreditar(this, monto);
    }
    public bool ValidarDebito(double monto) => Saldo - monto < 0 && cuenta.SaldoCuenta - monto < 0;
    public void DefinirEstado(IEstado estado)
    {
        _estado = estado;
    }
    public Guid DevolverCbu() => cuenta.Cbu;
    public double DevolverSaldo() => Saldo;
}