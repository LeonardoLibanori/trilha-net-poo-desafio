using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Smartphone Nokia");
        Nokia nokia = new Nokia("11111", "Nokia G21", "123456", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();
        Console.WriteLine("Smartphone iPhone");
        Iphone iphone = new Iphone("22222", "iPhone 14", "654321", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
