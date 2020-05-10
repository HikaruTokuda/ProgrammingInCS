using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProgrammingInCSharp_ASP.Models
{
    public class MusicTracksContext : DbContext
    {
        public MusicTracksContext (DbContextOptions<MusicTracksContext> options)
            : base(options)
        {
        }

        public DbSet<ProgrammingInCSharp_ASP.Models.MusicTrack> MusicTrack { get; set; }
    }
}
