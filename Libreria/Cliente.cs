namespace Libreria;

public class Cliente
{
    public string Nombre { get; set; } 
    public string Apellido { get; set; } 
    public double Saldo { get; set; }
    public Cuenta cuenta;
<<<<<<< HEAD
    public IEstado oEstado;
=======
    public IEstado _estado;
>>>>>>> 9c4d77730059eeed78476024e6c82b6f050f2219
    public Cliente(string nombre, string apellido, double saldo, Cuenta cuenta)
    {
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldo + cuenta.SaldoCuenta;
        this.cuenta = cuenta;
<<<<<<< HEAD
        oEstado = new Emergencia();
=======
        _estado = SelecionarEstado.AsignarEstado(this);
>>>>>>> 9c4d77730059eeed78476024e6c82b6f050f2219
    }
    public void DebitarEfectivo(double monto)
    {
        if (ValidarDebito(monto))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            _estado.Debitar(this, monto);
            _estado = SelecionarEstado.AsignarEstado(this);
        }
    }
    public void AcreditarEfectivo(double monto) 
    {
        _estado.Acreditar(this, monto);
        _estado = SelecionarEstado.AsignarEstado(this);
    }
    public bool ValidarDebito(double monto) => Saldo - monto < 0 && cuenta.SaldoCuenta - monto < 0;
    public Guid DevolverCbu() => cuenta.Cbu;
    public double DevolverSaldo() => Saldo;
}