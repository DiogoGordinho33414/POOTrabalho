namespace Reservas
{
    public abstract class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        protected Utilizador(int id, string nome, string email, string password)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Password = password;
        }

        public bool Autenticar(string email, string password)
        {
            // TODO: implementar
            return false;
        }
    }
}
