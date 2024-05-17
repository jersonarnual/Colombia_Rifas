using Colombia_Rifas.Domain.Domain;
using Colombia_Rifas.Domain.Domain.MasterTable;
using Microsoft.EntityFrameworkCore;

namespace Colombia_Rifas.Domain.Context
{
    public class RifasContext : DbContext
    {
        public RifasContext()
        {

        }
        public RifasContext(DbContextOptions<RifasContext> options)
            : base(options)
        {

        }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoSorteo> TipoSorteo { get; set; }
        public virtual DbSet<Anuncios> Anuncio { get; set; }
        public virtual DbSet<Boleto> Boleto { get; set; }
        public virtual DbSet<Ganador> Ganador { get; set; }
        public virtual DbSet<Pagos> Pago { get; set; }
        public virtual DbSet<Participacion> Participacion { get; set; }
        public virtual DbSet<Premio> Premio { get; set; }
        public virtual DbSet<Sorteo> Sorteo { get; set; }
        public virtual DbSet<SorteoPremio> SorteoPremio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
