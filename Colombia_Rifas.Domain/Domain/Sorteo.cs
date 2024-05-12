using Colombia_Rifas.Domain.Domain.MasterTable;

namespace Colombia_Rifas.Domain.Domain
{
    public class Sorteo : EntityBase
    {
        public Guid TipoSorteoId { get; set; }
        public Guid GanadorId { get; set; }
        public virtual TipoSorteo TipoSorteo { get; set; }
        public virtual ICollection<Ganador> Ganadores{ get; set; }
    }
}
