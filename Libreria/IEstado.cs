namespace Libreria;

public interface IEstado
{
    void Debitar(Cliente cliente, double monto);
    void Acreditar(Cliente cliente, double monto);
    bool SePuedeAplicar(Cliente cliente);
}