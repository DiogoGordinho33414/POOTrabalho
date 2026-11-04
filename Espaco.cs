using System.Collections.Generic;

namespace Reservas
{
    public class Espaco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Localizacao { get; set; }
        public int CapacidadeMaxima { get; set; }
        public bool Disponivel { get; set; }

        // Composição: os equipamentos pertencem ao espaço
        public List<Equipamento> Equipamentos { get; } = new List<Equipamento>();

        public Espaco(int id, string nome, string tipo, string localizacao,
                      int capacidadeMaxima, bool disponivel)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Localizacao = localizacao;
            CapacidadeMaxima = capacidadeMaxima;
            Disponivel = disponivel;
        }
    }
}
