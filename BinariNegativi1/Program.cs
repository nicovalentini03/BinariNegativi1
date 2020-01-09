using System;

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
            int value = 31;
            int somma = value;
            value = ~value + 1;//NOT
            //value = value+1;
            somma = somma + value;
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number2 = (short)number;
            Console.WriteLine(number2);
        }
    }
