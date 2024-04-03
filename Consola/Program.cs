using Libreria;

Cuenta cuenta = new Cuenta(400);
Cliente cliente = new Cliente("Pepito", "Perez", 1000, cuenta);

<<<<<<< HEAD
=======
System.Console.WriteLine(cliente._estado);
cliente.AcreditarEfectivo(100000);
System.Console.WriteLine(cliente._estado);
System.Console.WriteLine(cliente.Saldo);
>>>>>>> 9c4d77730059eeed78476024e6c82b6f050f2219
