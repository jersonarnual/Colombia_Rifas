namespace Colombia_Rifas.Domain.Domain
{
    public class Boleto : EntityBase
    {
        public Guid SorteoId { get; set; }
        public virtual ICollection<Sorteo> Sorteos { get; set; }
    }
}
