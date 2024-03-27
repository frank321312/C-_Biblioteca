namespace Libreria;

public class Emergencia : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Saldo += monto;
    }
    public void Debitar(Cliente cliente, double monto)
    {
        cliente.cuenta.SaldoCuenta -= monto;
        // cliente.Saldo = cliente.cuenta.SaldoCuenta;
        if (cliente.cuenta.SaldoCuenta < 0)
        {
            cliente.Saldo += cliente.cuenta.SaldoCuenta;
            cliente.cuenta.SaldoCuenta = 0;
        }
    }
    public void ControlarEstado(Cliente cliente)
    {
        cliente.DefinirEstado(SelecionarEstado.AsignarEstado(cliente));
    }
}
