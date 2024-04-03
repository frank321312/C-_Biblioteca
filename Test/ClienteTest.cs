using Xunit;
using Libreria;

namespace Test;

public class ClienteTest
{
    [Fact]
    public void ClienteHijitus()
    {
        // Primer cliente
        var cuentaHijitus = new Cuenta(0);
        var hijitus = new Cliente("Hijitus", "Apellido", 0, cuentaHijitus);

        hijitus.AcreditarEfectivo(3000);
        Assert.Equal(3_000, hijitus.Saldo);

        hijitus.AcreditarEfectivo(10000);
        Assert.Equal(13_000, hijitus.Saldo);
    }

    [Fact]
    public void ClienteNeurus()
    {
        // Segundo cliente
        var cuentaNeurus = new Cuenta(0);
        var Neurus = new Cliente("Neurus", "Apellido", 30000, cuentaNeurus);

        Neurus.AcreditarEfectivo(10000);
        Assert.Equal(38_000, Neurus.Saldo);
        Assert.Equal(2_000, Neurus.cuenta.SaldoCuenta);

        Neurus.DebitarEfectivo(5000);
        Assert.Equal(34_000, Neurus.Saldo);
        Assert.Equal(1_000, Neurus.cuenta.SaldoCuenta);
    }
    
    [Fact]
    public void ClienteGoldSilver()
    {
        // Tercer cliente
        var cuentaGoldSilver = new Cuenta(0);
        var GoldSilver = new Cliente("Gold Sivler", "Apellido", 100000, cuentaGoldSilver);

        GoldSilver.AcreditarEfectivo(100000);
        Assert.Equal(150_000, GoldSilver.Saldo);
        Assert.Equal(50_000, GoldSilver.cuenta.SaldoCuenta);

        GoldSilver.DebitarEfectivo(30000);
        Assert.Equal(120_000, GoldSilver.Saldo);
        Assert.Equal(50_000, GoldSilver.cuenta.SaldoCuenta);
    }
}
