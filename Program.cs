
using Aula_10._12._2025;

Atalhos atalhos = new Atalhos();
List<Perfil> perfils = new List<Perfil>();

int melhor = 0;
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

    for (int i = 0; i < 6; i++)
    {
        Perfil perfil = new Perfil();
        switch (i)
        {
            case 0:
                perfil.Nome = "Realista";
                perfil.Pontuacao = atalhos.Realista;
                break;

            case 1:
                perfil.Nome = "Investigativo";
                perfil.Pontuacao = atalhos.Investigativo;
                break;

            case 2:
                perfil.Nome = "Artístico";
                perfil.Pontuacao = atalhos.Artístico;
                break;

            case 3:
                perfil.Nome = "Social";
                perfil.Pontuacao = atalhos.Social;
                break;

            case 4:
                perfil.Nome = "Empreendedor";
                perfil.Pontuacao = atalhos.Empreendedor;
                break;

            case 5:
                perfil.Nome = "Convencional";
                perfil.Pontuacao = atalhos.Convencional;
                break;
        }
        perfils.Add(perfil);
    }

    int melhorNota = perfils.Max(m => m.Pontuacao);
    melhor = melhorNota;
    var perfilComMelhorPontuacao = perfils.Where(m => m.Pontuacao == melhorNota).ToList();

    if (perfilComMelhorPontuacao.Count > 1)
    {
        Console.WriteLine("\nVocê possui mais de um perfil com a maior pontuação!\n");
        Console.WriteLine("\nSeus perfis são:\n");
        foreach (var perfil in perfilComMelhorPontuacao)
        {
            Console.WriteLine($"Perfil: {perfil.Nome} - Pontuação: {perfil.Pontuacao}\n{perfil.Recomendacao()}\n");
        }
    }
    else
    {
        var perfil = perfilComMelhorPontuacao.First();
        Console.WriteLine($"\nSeu perfil é: {perfil.Nome} - Pontuação: {perfil.Pontuacao}\n{perfil.Recomendacao()}\n");
    }

    if (melhor == 16)
    {
        Console.WriteLine("\nVocê atingiu a nota máxima");
    }

    Console.WriteLine("\nDeseja repitir o questionário? Digite 's' para sim ou 'n' para não)");
    string resposta = Console.ReadLine()!;

    if (resposta == "s" || resposta == "sim")
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
