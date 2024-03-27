using Libreria;

Cuenta cuenta = new Cuenta(3000);
Cliente cliente = new Cliente("Pepito", "El mago", 40100, cuenta);

// System.Console.WriteLine(cliente.DevolverSaldo());
// cliente.DebitarEfectivo(40000);
cuenta.Debitar(cliente, 40000);
System.Console.WriteLine(cliente.DevolverSaldo());
System.Console.WriteLine(cliente.cuenta.DevolverSaldo());
System.Console.WriteLine(cliente._estado);
cuenta.Debitar(cliente, 1000);
System.Console.WriteLine(cliente.DevolverSaldo());
System.Console.WriteLine(cliente.cuenta.DevolverSaldo());
System.Console.WriteLine(cliente._estado);
