using Microsoft.EntityFrameworkCore;
using ProjetoAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgoraVai.Data
{
    public class Contexto : DbContext
    {
        public Contexto ( DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        public DbSet<Jogador> jogaadors { get; set; }
        public DbSet<Placar> placars { get; set; }
    }
}
