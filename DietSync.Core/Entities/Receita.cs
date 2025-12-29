namespace DietSync.Core.Entities
{
    public class Receita
    {
        public long Id { get; set; }
        public string NomeReceita { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        public double Calorias { get; set; }
        public double Proteinas { get; set; }
        public double Carboidratos { get; set; }
        public double Gorduras { get; set; }

        public int UsuarioId { get; set; }
        public User User { get; set; }
    }
}
