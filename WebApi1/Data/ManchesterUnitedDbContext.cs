using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebApi1.Models;


namespace WebApi1.Data;
public partial class ManchesterUnitedDbContext : IdentityDbContext
{
    public ManchesterUnitedDbContext(DbContextOptions<ManchesterUnitedDbContext> options) : base(options)
    {

    }

    public DbSet<ContactForm> ContactForm { get; set; }
    public DbSet<KategoriaProduktit> KategoriaProduktit { get; set; }
    public DbSet<KodiZbritjes> KodiZbritjes { get; set; }
    public DbSet<Kompania> Kompania { get; set; }
    public DbSet<Perdoruesi> Perdoruesi { get; set; }
    public DbSet<Porosit> Porosit { get; set; }
    public DbSet<Produkti> Produkti { get; set; }
    public DbSet<RegjistrimiStokut> RegjistrimiStokut { get; set; }
    public DbSet<StokuQmimiProduktit> StokuQmimiProduktit { get; set; }
    public DbSet<TeDhenatBiznesit> TeDhenatBiznesit { get; set; }
    public DbSet<TeDhenatEPorosis> TeDhenatEPorosis { get; set; }
    public DbSet<TeDhenatPerdoruesit> TeDhenatPerdoruesit { get; set; }
    public DbSet<TeDhenatRegjistrimit> TeDhenatRegjistrimit { get; set; }
    public DbSet<ZbritjaQmimitProduktit> ZbritjaQmimitProduktit { get; set; }

    public DbSet<Sculpture212261697> Sculpture212261697 { get; set; }

    public DbSet<Sculptor212261697> Sculptor212261697 { get; set; }

}
