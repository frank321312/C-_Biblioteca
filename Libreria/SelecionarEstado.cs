namespace Libreria;

public static class SelecionarEstado
{
    static List<IEstado> estados = new List<IEstado>() {new Emergencia(), new Cauto(), new Ahorrista()};
    public static IEstado AsignarEstado(Cliente cliente)
    {
        if (cliente.Saldo < 10000)
        {  
            return estados[0];
        }
        else if (cliente.Saldo >= 10000 && cliente.Saldo <= 50000)
        {
            return estados[1];
        }
        else
        {
            return estados.Last();
        }
    }
}