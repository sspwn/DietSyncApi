namespace DietSync.Core.Entities
{
    public class Evolucao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Cintura { get; set; }

        public int UsuarioId { get; set; }
        public User User { get; set; }
    }
}
