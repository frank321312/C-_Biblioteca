using Libreria;

Cuenta cuenta = new Cuenta(60000);
Cliente cliente = new Cliente("Pepito", "El mago", 10100, cuenta);

// System.Console.WriteLine(cliente.DevolverSaldo());
cliente.DebitarEfectivo(30000);
System.Console.WriteLine(cliente.DevolverSaldo());
System.Console.WriteLine(cliente.cuenta.DevolverSaldo());
System.Console.WriteLine(cliente._estado);
