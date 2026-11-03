using System;
using System.Collections.Generic;

namespace Reservas
{
    public class GestorReservas
    {
        // Composição: o gestor contém as listas
        public List<Utilizador> Utilizadores { get; } = new List<Utilizador>();
        public List<Espaco> Espacos { get; } = new List<Espaco>();
        public List<Reserva> Reservas { get; } = new List<Reserva>();

        public void RegistarUtilizador(Utilizador u)
        {
            // TODO: implementar
        }

        public Utilizador Login(string email, string password)
        {
            // TODO: implementar
            return null;
        }

        public Reserva CriarReserva(Utilizador u, Espaco espaco, DateOnly data,
                                    TimeOnly inicio, TimeOnly fim)
        {
            // TODO: implementar
            return null;
        }

        public void ConfirmarReserva(int id)
        {
            // TODO: implementar
        }

        public void CancelarReserva(int id)
        {
            // TODO: implementar
        }

        public bool ExisteConflito(Espaco espaco, DateOnly data,
                                   TimeOnly inicio, TimeOnly fim)
        {
            // TODO: implementar
            return false;
        }

        public int TotalReservas()
        {
            // TODO: implementar
            return 0;
        }

        public Dictionary<Espaco, int> ReservasPorEspaco()
        {
            // TODO: implementar
            return null;
        }

        public double TaxaOcupacao(Espaco espaco)
        {
            // TODO: implementar
            return 0.0;
        }
    }
}
