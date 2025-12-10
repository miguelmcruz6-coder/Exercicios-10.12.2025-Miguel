
using System.Collections;
using Aula_10._12._2025;

Atalhos atalhos = new Atalhos();

int melhor = 0;
int perfilselecionado1 = 0;
int perfilselecionado2 = 0;
int perfilselecionado3 = 0;
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
        if (melhor == perfil[i] && perfilselecionado1 != i)
        {
            perfilselecionado2 = perfil[i];
        }
        if (melhor == perfil[i] && perfilselecionado1 != i && perfilselecionado2 != i)
        {
            perfilselecionado3 = perfil[i];
        }
        if (melhor == perfil[i] && perfilselecionado1 != i && perfilselecionado2 != i && perfilselecionado3 != i)
        {
            exedeuLimite = true;
            break;
        }
    }

    if (perfilselecionado2 == 0)
    {
        atalhos.Resposta1(melhor, perfilselecionado1);
    }
    else if (perfilselecionado3 == 0)
    {
        atalhos.Resposta2(melhor, perfilselecionado1, perfilselecionado2);
    }
    else
    {
        atalhos.Resposta3(melhor, perfilselecionado1, perfilselecionado2, perfilselecionado3, exedeuLimite);
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
    }
    else
    {
        Console.WriteLine($"\nVocê quis brincar com a resposta, agora você vai responder tudo de novo\n");
    }
}