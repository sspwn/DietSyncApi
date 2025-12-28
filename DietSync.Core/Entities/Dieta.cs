namespace DietSync.Core.Entities
{
    public class Dieta
    {
        public long Id { get; private set; }
        public string NomeDieta { get; private set; }
        public string TipoDieta { get; private set; }
        public double Calorias { get; private set; }
        public double Proteinas { get; private set; }
        public double Carboidratos { get; private set; }
        public double Gorduras { get; private set; }
        public char DataDieta { get; private set; }
        public string Refeicao { get; private set; }
        public string Alimentos { get; private set; }
        public int Quantidade { get; private set; }
        public string Observacoes { get; private set; }

        // FK
        public int UsuarioId { get; private set; }
        public User User { get; private set; }
    }
}
