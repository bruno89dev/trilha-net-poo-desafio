using System;
using DesafioPOO.Models;

namespace DesafioPOO {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Smartphone Nokia");
            Nokia nokia = new Nokia("998887766", "5.4", "222333444", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Instagram");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Iphone iphone13 = new Iphone("998887755", "13", "444333222", 128);
            iphone13.ReceberLigacao();
            iphone13.InstalarAplicativo("Facebook");
            
        }
    }
}