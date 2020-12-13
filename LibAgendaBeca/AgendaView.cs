using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAgendaBeca
{
    public class AgendaView
    {
        public void ConsoleConfig()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }
        public void MenuPrincipal()
        {
            Agenda agenda = new Agenda();

            Boolean flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("DIGITE O QUE DESEJA FAZER:");
                Console.WriteLine("ADICIONAR PESSOA À AGENDA       [1]");
                Console.WriteLine("BUSCAR USUÁRIO POR NOME         [2]");
                Console.WriteLine("VER TODOS OS USUÁRIOS DA AGENDA [3]");
                Console.WriteLine("REMOVER USUÁRIO POR NOME        [4]");
                Console.WriteLine("SAIR DA AGENDA                  [0]");
                int operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        agenda.Adicionar();
                        break;

                    case 2:
                        agenda.ProcurarPorNome();
                        break;

                    case 3:
                        agenda.VerTodos();
                        break;

                    case 4:
                        agenda.RemoverPorNome();
                        break;

                    case 0:
                        flag = false;
                        Console.WriteLine("OBRIGADO PELA PREFERÊNCIA E VOLTE SEMPRE!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
