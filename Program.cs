﻿using System;

namespace CoreEscuela
{

class Escuela
{
   public string nombre;
   public string direccion;
   public int añofundacion;
   public string ceo ;

    public void Timbrar()
    {
        // to do
        Console.Beep(2000,3000);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

           var miEscuela = new Escuela();
           miEscuela.nombre = "Platzi Academy";
           miEscuela.direccion = "Calle 9 calle 72";
           miEscuela.añofundacion = 2012;
           Console.WriteLine("Timbrando");
           miEscuela.Timbrar();
           
        }
    }
}
