using System;
using POO_Cafeteira___Entrega.classes;

namespace POO_Cafeteira___Entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            bool outroCafe = true;
            bool cafe = true;
            Cafeteira cafeteira = new Cafeteira();

            Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |                  |     |
|     |    Ligando ...   |     |
|     |                  |     |
|     |                  |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |                          |
  |                          |
  |                          |
  |      _____________       |
  |      \            /|)    |
  |       \          /       |
  |  ______\________/______  |
 _|_|______________________|_|_
|                              |
|                              |
|______________________________|
  |__|                    |__|
");
            do
            {
                cafeteira.fazerCafe();
                do
                {

                    Console.WriteLine($@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |   Deseja fazer   |     |
|     |    outro café?   |     |
|     |                  |     |
|     | Sim(S) / Não(N)  |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |                          |
  |                          |
  |                          |
  |      _____________       |
  |      \            /|)    |
  |       \          /       |
  |  ______\________/______  |
 _|_|______________________|_|_
|                              |
|                              |
|______________________________|
  |__|                    |__|
");
                    string Sn = Console.ReadLine().ToLower();
                    if (Sn == "s")
                    {
                        outroCafe = false;
                        cafe = true;
                    }
                    else if (Sn == "n")
                    {
                        outroCafe = true;
                        cafe = true;
                    }
                    else
                    {
                        Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |                  |     |
|     |     Comando      |     |
|     |     Inválido     |     |
|     |                  |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |                          |
  |                          |
  |                          |
  |      _____________       |
  |      \            /|)    |
  |       \          /       |
  |  ______\________/______  |
 _|_|______________________|_|_
|                              |
|                              |
|______________________________|
  |__|                    |__|
");
                        cafe = false;
                    }
                } while (cafe == false);
            } while (outroCafe == false);
        }
    }
}
