using MiniStore.Domain.Entities;

namespace MiniStore.Infra.Data.EntitiesConfiguration.Data
{
    public class CategoriaDataSeeder
    {
        public static List<Categoria> IniciarCategorias()
        {
            return new List<Categoria>
        {
            new Categoria { Nome = "Material Escolar" },
            new Categoria { Nome = "Eletrônicos" },
            new Categoria { Nome = "Acessórios" },
            new Categoria { Nome = "Roupas e Moda" },
            new Categoria { Nome = "Casa e Decoração" },
            new Categoria { Nome = "Alimentos e Bebidas" },
            new Categoria { Nome = "Beleza e Cuidados Pessoais" },
            new Categoria { Nome = "Automotivo" },
            new Categoria { Nome = "Esportes e Atividades ao Ar Livre" },
            new Categoria { Nome = "Brinquedos e Jogos" },
            new Categoria { Nome = "Livros e Mídia" },
            new Categoria { Nome = "Saúde e Bem-Estar" },
            new Categoria { Nome = "Ferramentas e Equipamentos" },
            new Categoria { Nome = "Móveis" },
            new Categoria { Nome = "Joias e Acessórios" },
            new Categoria { Nome = "Instrumentos Musicais" },
            new Categoria { Nome = "Pet Shop e Animais de Estimação" }
        };
        }
    }
}
