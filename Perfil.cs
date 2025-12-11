using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10._12._2025
{
    public class Perfil
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        public string Recomendacao()
        {
            switch (Nome)
            {
                case "Realista":
                    return "Os cursos recomendados para este perfil são:  Mecânica, Automação, Usinagem, Eletricidade, Plastico, Costura.";
                case "Investigativo":
                    return "Os cursos recomendados para este perfil são: Tecnologia da Informação, Eletroeletrônica, Manutenção, Plastico.";
                case "Artístico":
                    return "Os cursos recomendados para este perfil são: Design de Produto, Impressão 3D, Comunicação Visual, Costura.";
                case "Social":
                    return "Os cursos recomendados para este perfil são: Segurança do Trabalho, Educação, Saúde Ocupacional.";
                case "Empreendedor":
                    return "Os cursos recomendados para este perfil são: Administração, Marketing, Direito.";
                case "Convencional":
                    return "Os cursos recomendados para este perfil são: Administração, Controle de Qualidade, Planejamento.";
                default:
                    return "Perfil desconhecido.";
            }
        }
    }
}