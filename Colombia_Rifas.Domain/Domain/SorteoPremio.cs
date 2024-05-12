namespace Colombia_Rifas.Domain.Domain
{
    public class SorteoPremio : EntityBase
    {
        public Guid SorteoId { get; set; }
        public Guid PremioId { get; set; }
        public virtual ICollection<Sorteo> Sorteos { get; set; }
        public virtual ICollection<Premio> Premios { get; set; }
    }
}
