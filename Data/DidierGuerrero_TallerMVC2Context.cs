using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DidierGuerrero_TallerMVC2.Models;

namespace DidierGuerrero_TallerMVC2.Data
{
    public class DidierGuerrero_TallerMVC2Context : DbContext
    {
        public DidierGuerrero_TallerMVC2Context (DbContextOptions<DidierGuerrero_TallerMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<DidierGuerrero_TallerMVC2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<DidierGuerrero_TallerMVC2.Models.Promo> Promo { get; set; }
    }
}
