using System;

namespace Reservas
{
    public class Reserva
    {
        public int Id { get; set; }
        public Utilizador Utilizador { get; set; }
        public Espaco Espaco { get; set; }
        public DateOnly Data { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFim { get; set; }
        public EstadoReserva Estado { get; set; }

        public Reserva(int id, Utilizador utilizador, Espaco espaco,
                       DateOnly data, TimeOnly horaInicio, TimeOnly horaFim)
        {
            Id = id;
            Utilizador = utilizador;
            Espaco = espaco;
            Data = data;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Estado = EstadoReserva.PENDENTE;
        }

        public void Confirmar()
        {
            // TODO: implementar
        }

        public void Cancelar()
        {
            // TODO: implementar
        }

        public void Concluir()
        {
            // TODO: implementar
        }
    }
}
