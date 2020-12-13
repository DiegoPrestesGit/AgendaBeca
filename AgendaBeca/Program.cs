using LibAgendaBeca;
using System;

namespace AgendaBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.Read();
        }

        public static void Execute()
        {
            AgendaView agendaView = new AgendaView();
            agendaView.ConsoleConfig();
            agendaView.MenuPrincipal();
            Console.Read();
        }
    }
}
