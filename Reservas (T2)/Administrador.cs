namespace Reservas
{
    public class Administrador : Utilizador
    {
        public Administrador(int id, string nome, string email, string password)
            : base(id, nome, email, password)
        {
        }
    }
}
