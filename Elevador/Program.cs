using System;
using Elevador.classes;
namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoDe;
            string subirAcima;
            string pessoaMais;
            string descerAbaixo;
            string pessoaMenos;
            string caixaMais;
            string caixaMenos;
            bool acabou = false;
            bool finalizar = true;

            do
            {

                do
                {
                    Console.WriteLine(@"
_______________________________
||                           ||
||   Selecione uma opção:    ||
||___________________________||
||                           ||
||  1 - Elevador Social      ||
||  2 - Elevador de Serviço  ||
||  3 - Sair                 ||
||___________________________||
");
                    tipoDe = Console.ReadLine();

                    if (tipoDe == "1")
                    {

                        elevadorSocial eleSoc = new elevadorSocial();

                        eleSoc.Inicializar();

                        do
                        {
                            Console.WriteLine(@"
_______________________________
||                           ||
||   Selecione uma opção:    ||
||___________________________||
||                           ||
||  1 - Entrar               ||
||  2 - Sair                 ||
||  3 - Subir                ||
||  4 - Descer               ||
||  5 - Parar                ||
||___________________________||
");
                            string opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    do
                                    {
                                        eleSoc.EntrarSoc();
                                        Console.WriteLine("Mais alguém entrará no elevador?\ns - Sim\nn - Não");
                                        pessoaMais = Console.ReadLine();
                                    } while (pessoaMais == "s");
                                    acabou = false;
                                    break;

                                case "2":
                                    do
                                    {
                                        eleSoc.SairSoc();
                                        Console.WriteLine("Mais alguém sairá no elevador?\ns - Sim\nn - Não");
                                        pessoaMenos = Console.ReadLine();
                                    } while (pessoaMenos == "s");
                                    acabou = false;
                                    break;

                                case "3":
                                    do
                                    {
                                        eleSoc.Subir();
                                        Console.WriteLine("Deseja Subir mais?\ns - Sim\nn - Não");
                                        subirAcima = Console.ReadLine();
                                    } while (subirAcima == "s");
                                    acabou = false;
                                    break;


                                case "4":
                                    do
                                    {
                                        eleSoc.Descer();
                                        Console.WriteLine("Deseja Descer mais?\ns - Sim\nn - Não");
                                        descerAbaixo = Console.ReadLine();
                                    } while (descerAbaixo == "s");
                                    acabou = false;
                                    break;

                                case "5":
                                    acabou = true;
                                    break;

                                default:

                                    break;
                            }
                        } while (acabou == false);
                    }

                    else if (tipoDe == "2")
                    {

                        elevadorServico eleSer = new elevadorServico();

                        eleSer.InicializarSer();

                        do
                        {
                            Console.WriteLine(@"
_______________________________
||                           ||
||   Selecione uma opção:    ||
||___________________________||
||                           ||
||  1 - Entrar               ||
||  2 - Sair                 ||
||  3 - Subir                ||
||  4 - Descer               ||
||  5 - Adicionar Caixa      ||
||  6 - Remover Caixa        ||
||  7 - Parar                ||
||___________________________||
");
                            string opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    do
                                    {
                                        eleSer.EntrarSer();
                                        Console.WriteLine("Mais alguém entrará no elevador?\ns - Sim\nn - Não");
                                        pessoaMais = Console.ReadLine();
                                    } while (pessoaMais == "s");
                                    acabou = false;
                                    break;

                                case "2":
                                    do
                                    {
                                        eleSer.SairSer();
                                        Console.WriteLine("Mais alguém sairá no elevador?\ns - Sim\nn - Não");
                                        pessoaMenos = Console.ReadLine();
                                    } while (pessoaMenos == "s");
                                    acabou = false;
                                    break;

                                case "3":
                                    do
                                    {
                                        eleSer.Subir();
                                        Console.WriteLine("Deseja Subir mais?\ns - Sim\nn - Não");
                                        subirAcima = Console.ReadLine();
                                    } while (subirAcima == "s");
                                    acabou = false;
                                    break;


                                case "4":
                                    do
                                    {
                                        eleSer.Descer();
                                        Console.WriteLine("Deseja Descer mais?\ns - Sim\nn - Não");
                                        descerAbaixo = Console.ReadLine();
                                    } while (descerAbaixo == "s");
                                    acabou = false;
                                    break;

                                case "5":
                                    do
                                    {
                                        eleSer.MaisCaixa();
                                        Console.WriteLine("Deseja colocar mais uma caixa no elevador?\ns - Sim\nn - Não");
                                        caixaMais = Console.ReadLine();
                                    } while (caixaMais == "s");
                                    acabou = false;
                                    break;

                                case "6":
                                    do
                                    {
                                        eleSer.MenosCaixa();
                                        Console.WriteLine("Deseja retirar uma caixa do elevador?\ns - Sim\nn - Não");
                                        caixaMenos = Console.ReadLine();
                                    } while (caixaMenos == "s");
                                    acabou = false;
                                    break;

                                case "7":
                                    acabou = true;
                                    break;

                                default:

                                    break;
                            }
                        } while (acabou == false);
                    }
                    else if (tipoDe == "3")
                    {
                        finalizar = true;
                        acabou = false;
                    }

                    else
                    {
                        finalizar = false;
                    }

                } while (acabou == true);
            } while (finalizar == false);
        }
    }
}