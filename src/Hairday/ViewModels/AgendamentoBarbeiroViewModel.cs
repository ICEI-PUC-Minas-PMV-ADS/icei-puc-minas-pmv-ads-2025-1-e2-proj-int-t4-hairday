using Hairday.Models;
using System;
using System.Collections.Generic;

namespace Hairday.ViewModels
{
    public class AgendamentoBarbeiroViewModel
    {
        public List<DateTime> ProximasDatas { get; set; } = new List<DateTime>();
        public DateTime? DataSelecionada { get; set; }
        public List<Horario_Disponivel> HorariosDisponiveis { get; set; } = new List<Horario_Disponivel>();
        public int? HorarioSelecionadoId { get; set; }

        public Agendamento? AgendamentoSelecionado { get; set; }
        public Cliente? ClienteDoAgendamento { get; set; }
        public List<string> Servicos { get; set; } = new List<string>();

        public bool MostrarHorarios { get; set; } = false;
        public bool MostrarDetalhes { get; set; } = false;

        // ✅ Controle de Remarcação (padronizado)
        public bool EmModoRemarcacao { get; set; } = false;
        public int? IdAgendamentoRemarcando { get; set; }
    }
}