﻿using Libreria;

Cuenta cuenta = new Cuenta(50);
Cliente cliente = new Cliente("Pepito", "El mago", 10000, cuenta);

cliente.EstadoCliente();
// cliente.EstadoEmergencia();
cliente.EstadoCauto().EstadoCliente(cliente.Saldo);