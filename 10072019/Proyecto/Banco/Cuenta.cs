﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    //Cree una clase Cuenta que almacena el saldo actual y proporciona los métodos 
    //getBalance para obtener el saldo y deposit para depositar fondos
    //withdraw para reitrar fondos y toString para devolver por pantalla el saldo actual
    //además de al menos un constructor
    class Cuenta
    {
        private double saldoActual;

        public Cuenta()
        {

        }
        public static double getBalance()
        {
            throw new Exception("Metodo no implementado");
        }

        public static void deposit(double nuevosFondos)
        {
            throw new Exception("Metodo no implementado");
        }
        public static void withdraw(double retirarFondos)
        {
            throw new Exception("Metodo no implementado");
        }

        public override string ToString()
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
