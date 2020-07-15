using System;

namespace GuiaGit
{
    class Program
    {
        static string msg1 = "1) Criar repositório";
        static string msg2 = "2) Criar sua identificação";
        static string msg3 = "3) Adicionar arquivos para a fila do commit";
        static string msg4 = "4) Efetuar commit";
        static string msg5 = "5) Visualizar commits anteriores / voltar para a branch";
        static string msg6 = "6) Efetuar rollback";
        static string msg0 = "0) Sair do programa";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem vindo ao guiagit!");
                Console.WriteLine("Selecione a opção que desejas verificar");
                Console.WriteLine(msg1);
                Console.WriteLine(msg2);
                Console.WriteLine(msg3);
                Console.WriteLine(msg4);
                Console.WriteLine(msg5);
                Console.WriteLine(msg6);
                Console.WriteLine(msg0);

                int key = Console.Read();
                char ch = Convert.ToChar(key);

                Console.Clear();
                switch (ch)
                {
                    case '1':
                        CriarRepositorio();
                        break;
                    case '2':
                        CriarIdentificacao();
                        break;
                    case '3':
                        AdicionarArquivosFilaCommit();
                        break;
                    case '4':
                        ExecutarCommit();
                        break;
                    case '5':
                        VisualizarCommitsEVoltarParaBranch();
                        break;
                    case '6':
                        EfetuarRollback();
                        break;
                    case '0':
                        Sair();
                        break;
                    default:
                        Console.WriteLine("A opção " + ch + " é inválida!");
                        break;
                }
                PressioneEnterParaContinuar();
                Console.Clear();
            }
        }

        private static void PressioneEnterParaContinuar()
        {
            Console.Write("Aperte enter para continuar... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.ReadLine();
        }

        private static void Sair()
        {
            Boolean backToApp = false;
            while (!backToApp)
            {
                Console.Clear();
                Console.WriteLine("Tem certeza que deseja sair desse maravilhoso programa?");
                Console.WriteLine("Y - Sim!        N - Não!");
                int key = Console.Read();
                char ch = Convert.ToChar(key);

                switch (ch)
                {
                    case 'y':
                        Environment.Exit(0);
                        break;
                    case 'Y':
                        Environment.Exit(0);
                        break;
                    case 'n':
                        backToApp = true;
                        break;
                    case 'N':
                        backToApp = true;
                        break;

                }
            }
        }

        private static void CriarRepositorio() 
        {
            Console.WriteLine(msg1);
        }
        private static void CriarIdentificacao() 
        {
            Console.WriteLine(msg2);
        }
        private static void AdicionarArquivosFilaCommit() 
        {
            Console.WriteLine(msg3);
        }
        private static void ExecutarCommit() 
        {
            Console.WriteLine(msg4);
        }
        private static void VisualizarCommitsEVoltarParaBranch() 
        {
            Console.WriteLine(msg5);
        }
        private static void EfetuarRollback() 
        {
            Console.WriteLine(msg6);
        }
    }
}
