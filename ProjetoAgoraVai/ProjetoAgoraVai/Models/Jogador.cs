using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgoraVai.Models
{
    public class Jogador
    {
            public int JogadorId { get; set; }
            [Required(ErrorMessage = "Campo Obritgatório", AllowEmptyStrings = false)]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Campo Obritgatório", AllowEmptyStrings = false)]
            public int Idade { get; set; }
            [Required(ErrorMessage = "Campo Obritgatório", AllowEmptyStrings = false)]
            public string Nacionalidade { get; set; }
        }
    }
