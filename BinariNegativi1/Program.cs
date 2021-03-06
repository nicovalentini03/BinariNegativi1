﻿using System;

namespace BinariNegativi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);
            if (a == 214783647)
            {
                Console.WriteLine(a + 1);
            }
            //Nella riga 10 viene stampato il numero massimo di una variabile int,
            //nella riga 11 il programma va in overflow perchè è stato superato il massimo numero di una var intera
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            //nella riga 15 il numero 128 viene converito in binario e poi stampato
            Console.WriteLine("Inserisci un numero intero");
            int value = int.Parse(Console.ReadLine());
            int somma = value;
            value = ~value + 1;//NOT
            //value = value+1;
            somma = somma + value;
            Console.WriteLine($"{value} è l'opposto del numero inserito e {somma} è la somma tra il valore inserito e l'opposto");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2)); //number si converte in binario
            short number1 = (short)number; //la variabile number diventa short
            Console.WriteLine(number1); //stampa il valore di number1, pero' è sbagliato perchè il numero long è 55555 quando
                                        //le variabili short vanno da da -32,768 a 32,767 e quindi va in overflow e stampa -9981.
                                        
            Console.ReadLine();
        }
    }
}
