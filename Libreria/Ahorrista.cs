namespace Libreria;

public class Ahorrista : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Saldo += monto * 0.5;
        cliente.cuenta.SaldoCuenta += monto * 0.5;
    }
    public void Debitar(Cliente cliente, double monto)
    {
        cliente.Saldo -= monto;
        if (cliente.Saldo < 0)
        {
            // cliente.Saldo -= monto;
            cliente.cuenta.SaldoCuenta += cliente.Saldo;
            cliente.Saldo = 0;
        }
    }
    public void ControlarEstado(Cliente cliente)
    {
        cliente.DefinirEstado(SelecionarEstado.AsignarEstado(cliente));
    }
}
