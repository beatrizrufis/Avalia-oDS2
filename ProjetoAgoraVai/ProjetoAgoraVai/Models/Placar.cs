using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgoraVai.Models
{
    public class Placar
    {
            public int PlacarId { get; set; }

            public virtual Jogador Jogador { get; set; }
            public int JogadorId { get; set; }

            [Display(Description = "Total de Pontos")]
            public int Pontos { get; set; }

            [DataType(DataType.Date)]
            [Display(Description = "Data da Pontuação")]
            public DateTime Data { get; set; }
        }
    }