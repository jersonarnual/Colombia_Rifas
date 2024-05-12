namespace Colombia_Rifas.Domain.Domain
{
    public class Participacion : EntityBase
    {
        public Guid UsuarioId { get; set; }
        public Guid BoletoId { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Boleto> Boletos{ get; set; }

    }
}
