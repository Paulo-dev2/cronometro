using System;
using System.Diagnostics;
using System.Threading;

class Cronometro
{

    public static void Main(string[] args)
    {


        String opcao = "";
        Console.WriteLine("Cronometro:");
        Console.WriteLine("Digite (m) para minutos ou (s) para segundos");
        opcao = Console.ReadLine();

        if(opcao == "m")
        {
            int m = 0;
            int time;
            Console.WriteLine("Digite quantos minutos voce deseja: ");
            m = Convert.ToInt32(Console.ReadLine());
            time = m * 60;
            var timer = new Stopwatch();
            timer.Start();
            while (time != 0)
            {
                int minuto, segundo, hora = 0;
                minuto = (time / 60) % 60;
                segundo = time % 60;
                hora = minuto / 60;
                Thread.Sleep(1000);
                Console.WriteLine(hora + ":" + minuto + ":" + segundo);
                time--;

            }
            timer.Stop();
        }
        if (opcao == "s")
        {
            int s = 0;
            int time;
            Console.WriteLine("Digite quantos segundos voce deseja: ");
            s = Convert.ToInt32(Console.ReadLine());
            time = s;
            var timer = new Stopwatch();
            timer.Start();
            while (time != 0)
            {
                int minuto, segundo, hora = 0;
                minuto = (time / 60) % 60;
                segundo = time % 60;
                hora = minuto / 60;
                Thread.Sleep(1000);
                Console.WriteLine(hora + ":" + minuto + ":" + segundo);
                time--;

            }
            timer.Stop();
        }
    }
}