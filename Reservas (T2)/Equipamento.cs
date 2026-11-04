namespace Reservas
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Estado { get; set; }

        public Equipamento(int id, string nome, int quantidade, string estado)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Estado = estado;
        }
    }
}
