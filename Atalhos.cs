using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Aula_10._12._2025
{
    public class Atalhos
    {
        public int Realista { get; set; }
        public int Investigativo { get; set; }
        public int Artístico { get; set; }
        public int Social { get; set; }
        public int Empreendedor { get; set; }
        public int Convencional { get; set; }
        public string Opcoes()
        {
            return "\n0  O\t\t1  O\t\t2  O\t\t3  O\t\t4  O\n\t\t";
        }
        public void OpcoesRealista()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de trabalhar com ferramentas, máquinas ou objetos.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Prefiro atividades práticas a discussões teóricas.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Gosto de consertar, montar ou construir coisas.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Prefiro ambientes organizados e tarefas manuais.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Realista += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
        public void OpcoesInvestigativo()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de resolver problemas complexos.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Tenho interesse em ciência, pesquisa ou experimentos.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Gosto de analisar informações e entender como as coisas funcionam.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Prefiro atividades que envolvam reflexão e lógica.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Investigativo += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }

            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
        public void OpcoesArtístico()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de criar, desenhar, inventar ou expressar ideias.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Prefiro atividades com liberdade e sem regras rígidas.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Gosto de música, artes visuais, escrita ou atuação.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Sou imaginativo(a) e busco formas diferentes de fazer as coisas.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Artístico += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
        public void OpcoesSocial()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de ajudar, orientar ou cuidar de pessoas.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Tenho facilidade para ouvir e compreender os outros.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Prefiro atividades que envolvem ensinar ou apoiar alguém.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Social += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
        public void OpcoesEmpreendedor()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de liderar, convencer ou motivar pessoas.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Tenho iniciativa e gosto de tomar decisões.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Prefiro desafios que envolvam resultados e metas.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Gosto de criar projetos e colocar ideias em prática.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Empreendedor += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
        public void OpcoesConvencional()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"1. Gosto de organizar, planejar e manter tudo em ordem.\n{Opcoes()}");
                        break;
                    case 1:
                        Console.WriteLine($"\n2. Prefiro atividades com regras claras e rotina.\n{Opcoes()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n3. Gosto de trabalhar com documentos, tabelas ou registros.\n{Opcoes()}");
                        break;
                    case 3:
                        Console.WriteLine($"\n4. Sou detalhista e cuidadoso(a) com informações.\n{Opcoes()}");
                        break;
                }
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta < 5 && resposta >= 0)
                {
                    Empreendedor += resposta;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------\n");
        }
    }
}
