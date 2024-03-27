using Libreria;

Cuenta cuenta = new Cuenta(400);
Cliente cliente = new Cliente("Pepito", "Perez", 3000, cuenta);

System.Console.WriteLine(cliente._estado);
System.Console.WriteLine(cliente._estado.SePuedeAplicar(cliente));
cliente.MostrarMensaje();