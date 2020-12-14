using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace LibAgendaBeca
{
    public class Agenda
    {
        public void HandleDiretorio()
        {
            string dirName = @"C:\temp";
            string fileName = @"C:\temp\agenda.txt";
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

        }

        public void Adicionar()
        {
            string fileName = @"C:\temp\agenda.txt";

            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a altura de {nome}: ");
            Console.WriteLine($"Ex: 1.70");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Usuario user = new Usuario(nome, altura, idade);

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(user.DadosUsuario());
            }
            Console.WriteLine("Usuário criado com sucesso");
            Console.WriteLine(user.DadosUsuario());
            Console.ReadLine();
        }

        public void ProcurarPorNome()
        {
            Console.WriteLine("Digite o nome do usuário que quer procurar");
            string username = Console.ReadLine();
            string fileName = @"C:\temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach(string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if(splitedLine[0] == $"Nome: {username}")
                {
                    string rightLine = line;
                    Console.WriteLine($"usuário encontrado:");
                    Console.WriteLine(rightLine);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Usuário não encontrado!");
            Console.ReadLine();
        }

        public void VerTodos()
        {
            string fileName = @"C:\temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }

        public void RemoverPorNome()
        {
            Console.WriteLine("Digite o nome do usuário que quer remover");
            string username = Console.ReadLine();
            string fileName = @"C:\temp\agenda.txt";
            Boolean encontrado = false;
            List<string> newLines = new List<string>();
            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if (splitedLine[0] == $"Nome: {username}")
                {
                    string rightLine = line;
                    Console.WriteLine($"usuário encontrado:");
                    Console.WriteLine(rightLine);
                    
                    Console.ReadLine();
                    encontrado = true;
                }
                else
                {
                    newLines.Add(line);
                }
            }

            if (encontrado)
            {
                File.WriteAllText(fileName, String.Empty);

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    foreach (string line in newLines)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Deleção efetuada com sucesso");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
                Console.ReadLine();
            }
        }
    }
}
