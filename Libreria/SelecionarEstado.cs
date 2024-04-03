namespace Libreria;

public static class SelecionarEstado
{
    static List<IEstado> estados = new List<IEstado>() {new Emergencia(), new Cauto(), new Ahorrista()};
    public static IEstado AsignarEstado(Cliente cliente)
    {
        return estados.First(x => x.SePuedeAplicar(cliente) == true);       
    }
}