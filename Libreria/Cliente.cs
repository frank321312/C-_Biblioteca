﻿namespace Libreria;

public class Cliente
{
    public string Nombre { get; set; } 
    public string Apellido { get; set; } 
    public double Saldo { get; set; }
    public Cuenta cuenta;
    private IEstado oEstado;
    public Cliente(string nombre, string apellido, double saldo, Cuenta cuenta)
    {
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldo + cuenta.SaldoCuenta;
        this.cuenta = cuenta;
    }
    public void EstadoEmergencia()
    {
        oEstado = new Emergencia();
    }
    public void DebitarEfectivo(double monto)
    {
        if (ValidarDebito(monto))
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            Saldo -= monto * 0.8;
            cuenta.SaldoCuenta -= monto * 0.2;
        }
    }
    public void AcreditarEfectivo(double monto) 
    {
        Saldo += monto * 0.8;
        cuenta.SaldoCuenta += monto * 0.2;
    }
    public bool ValidarDebito(double monto) => Saldo - monto < 0;
}