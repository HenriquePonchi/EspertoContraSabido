using System;

namespace EspertoContraSabido
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 22;
            int picaPau = 0;
            int raposinha = 0;

            int rodada = 1;

            Console.WriteLine("--- Esperto Contra Sabido ---");
            Console.WriteLine($"\nQuantos alimentos serão distribuídos? {total}\n");

            while (total > 0)
            {
                // Pica-pau pega "rodada" alimentos
                int pegarPicaPau = Math.Min(rodada, total);
                total -= pegarPicaPau;
                picaPau += pegarPicaPau;

                Console.Write($" {rodada} para você.");
                if (total <= 0) break;

                // Raposinha pega 1..rodada (ou o que restar)
                int pegarRaposinha = 0;
                for (int i = 1; i <= rodada && total > 0; i++)
                {
                    total--;
                    pegarRaposinha++;
                }

                raposinha += pegarRaposinha;

                Console.Write(" ");
                for (int i = 1; i <= pegarRaposinha; i++)
                    Console.Write($"{i}" + (i < pegarRaposinha ? ", " : ""));
                Console.WriteLine(" para mim.");

                rodada++;
            }

            Console.WriteLine($"\nPica-pau recebeu {picaPau} alimento(s).");
            Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
        }
    }
}