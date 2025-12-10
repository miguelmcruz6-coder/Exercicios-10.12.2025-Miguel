
using System.Collections;
using Aula_10._12._2025;

Atalhos atalhos = new Atalhos();

int melhor = -1;
int perfilselecionado1 = -1;
int perfilselecionado2 = -1;
int perfilselecionado3 = -1;
bool exedeuLimite = false;
bool continuar = true;


while (continuar)
{

    Console.WriteLine("\n\t\t\tEssa pesquisa irá fazez questões para saber seu perfil\n\n0 – Nada a ver\t\t1 – Pouco\t\t2 – Parcialmente\t\t3 – Bastante\t\t4 – Totalmente\n");

    atalhos.OpcoesRealista();
    atalhos.OpcoesInvestigativo();
    atalhos.OpcoesArtístico();
    atalhos.OpcoesSocial();
    atalhos.OpcoesEmpreendedor();
    atalhos.OpcoesConvencional();

    int[] perfil = new int[6] { atalhos.Realista, atalhos.Investigativo, atalhos.Artístico, atalhos.Social, atalhos.Empreendedor, atalhos.Convencional };

    for (int i = 0; i < 6; i++)
    {
        if (melhor < perfil[i])
        {
            melhor = perfil[i];
            perfilselecionado1 = i;
        }
        else if (melhor == perfil[i] && perfilselecionado1 != i)
        {
            perfilselecionado2 = perfil[i];
        }
        else if (melhor == perfil[i] && perfilselecionado1 != i && perfilselecionado2 != i)
        {
            perfilselecionado3 = perfil[i];
        }
        else if (melhor == perfil[i] && perfilselecionado1 != i && perfilselecionado2 != i && perfilselecionado3 != i)
        {
            exedeuLimite = true;
            break;
        }
    }

    if (perfilselecionado3 != -1)
    {
        atalhos.Resposta3(melhor, perfilselecionado1, perfilselecionado2, perfilselecionado3, exedeuLimite);
    }
    else if (perfilselecionado2 != -1)
    {
        atalhos.Resposta2(melhor, perfilselecionado1, perfilselecionado2);
    }
    else if (perfilselecionado3 != -1)
    {
        atalhos.Resposta1(melhor, perfilselecionado1);
    }

    if(melhor == 16)
    {
        Console.WriteLine("\nVocê atingiu a nota máxima");
    }
    
    Console.WriteLine("\nDeseja repitir o questionário? Digite 's' para sim ou 'n' para não)");
    string resposta = Console.ReadLine()!;

    if(resposta == "s" || resposta == "sim")
    {
        Console.WriteLine("\nVamos Constinuar!!! \n");
    }
    else if (resposta == "n")
    {
        Console.WriteLine("\nAté uma próxima \n");
        continuar = false;
    }
    else
    {
        Console.WriteLine($"\nVocê quis brincar com a resposta, agora você vai responder tudo de novo\n");
    }
}
