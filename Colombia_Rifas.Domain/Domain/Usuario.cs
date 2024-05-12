namespace Colombia_Rifas.Domain.Domain
{
    public class Usuario : EntityBase
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentidad { get; set; }
        public Guid AnuncioId { get; set; }
        public virtual ICollection<Anuncios> Anuncios { get; set; }
    }
}
