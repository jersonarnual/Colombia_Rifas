using Colombia_Rifas.Domain.Domain.MasterTable;

namespace Colombia_Rifas.Domain.Domain
{
    public class Pagos : EntityBase
    {
        public Guid ParticipacionId { get; set; }
        public Guid TipoPagoId{ get; set; }
        public virtual ICollection<Participacion> Participacion { get; set; }
        public virtual TipoPago TipoPago{ get; set; }
    }
}
