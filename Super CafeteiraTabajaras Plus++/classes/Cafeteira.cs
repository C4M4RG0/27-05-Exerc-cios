using System;
namespace POO_Cafeteira___Entrega.classes
{
    public class Cafeteira
    {
        private int acucarDisponivel = 1000;
        public void fazerCafe(int acucar)
        {
            if (acucarDisponivel < acucar)
            {
                Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |   Quantidade de  |     |
|     |  açucar desejada |     |
|     |   indisponível   |     |
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
            }
            else
            {
                Console.WriteLine($@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |   Seu café com   |     |
|     |{acucar} gramas de açucar   
|     |    está sendo    |     |
|     |     preparado    |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |            ||            |
  |            ||            |
  |            ||            |
  |            ||            |
  |            ||            |
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
                acucarDisponivel = acucarDisponivel - acucar;
                Console.WriteLine($@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |   Seu café com   |     |
|     |açucar está pronto|     |
|     |                  |     |
|     | Sobram {acucarDisponivel} gramas
|     |   de açucar na   |     |
|     |     máquinha     |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |        (    )    )       |
  |         )  (    (        |
  |        (    )    )       |
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
            }
        }
        public void fazerCafe()
        {
            bool loopUm = true;
            bool loopDois = true;
            do
            {

                Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |   Deseja fazer   |     |
|     |    o café? com   |     |
|     |  ou sem açucar?  |     |
|     |                  |     |
|     | Com(C) / Sem(S)  |     |
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
                string escolha = Console.ReadLine().ToLower();
                if (escolha == "c")
                {
                    loopUm = true;
                    do
                    {
                        Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |  Deseja escolher |     |
|     |   quantas gramas |     |
|     |de açucar irão ser|     |
|     |     colocadas    |     |
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
                            Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |     Digite a     |     |
|     |  quantidade de   |     |
|     |  açucar desejada |     |
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
                            int acucar = int.Parse(Console.ReadLine());
                            fazerCafe(acucar);
                            loopDois = true;
                        }
                        else if (Sn == "n")
                        {
                            acucarDisponivel = acucarDisponivel - 10;
                            Console.WriteLine($@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |    Por padrão    |     |
|     |   foi colocado   |     |
|     |10 gramas no café |     |
|     |                  |     |
|     |   Seu café está  |     |
|     |      pronto      |     |
|     |                  |     |
|     | Restam {acucarDisponivel} gramas 
|     |   de açucar na   |     |
|     |     máquina      |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |        (    )    )       |
  |         )  (    (        |
  |        (    )    )       |
  |      _____________       |
  |      \            /|)    |
  |       \          /       |
  |  ______\________/______  |
 _|_|______________________|_|_
|                              |
|                              |
|______________________________|
  |__|                    |__|
Por padrão colocamos 10 gramas de açucar no seu café
Seu café com açucar está pronto para consumo
Restam {acucarDisponivel} gramas de açucar na sua máquina de café
");
                            loopDois = true;
                        }
                        else
                        {
                            Console.WriteLine("Comando inválido");
                            loopDois = false;
                        }
                    } while (loopDois == false);
                }
                else if (escolha == "s")
                {
                    loopUm = true;
                    Console.WriteLine(@"
   __________________________ 
 _|__________________________|_
|     |                  |     |
|     |  Super Cafeteira |     |
|     | Tabajaras Plus++ |     |
|     |__________________|     |
|     |                  |     |
|     |   seu café sem   |     |
|     |    açucar está   |     |
|     |      pronto      |     |
|     |__________________|     |
|______________________________| 
  |  |____________________|  |
  |           |__|           |
  |                          |
  |                          |
  |        (    )    )       |
  |         )  (    (        |
  |        (    )    )       |
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
|     |     Comando      |     |
|     |     inválido     |     |
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
                    loopUm = false;
                }
            } while (loopUm == false);
        }
    }
}
