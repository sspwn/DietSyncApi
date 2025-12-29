namespace DietSync.Core.Entities
{
    public class Dieta
    {
        public Dieta(string nomeDieta, string tipoDieta, double calorias, double proteinas, double carboidratos, double gorduras, char dataDieta, string refeicao, string alimentos, int quantidade, string observacoes, int usuarioId)
        {
            NomeDieta = nomeDieta;
            TipoDieta = tipoDieta;
            Calorias = calorias;
            Proteinas = proteinas;
            Carboidratos = carboidratos;
            Gorduras = gorduras;
            DataDieta = dataDieta;
            Refeicao = refeicao;
            Alimentos = alimentos;
            Quantidade = quantidade;
            Observacoes = observacoes;
            UsuarioId = usuarioId;
        }

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

        public void Update(string nomeDieta, string tipoDieta, double calorias, double proteinas, double carboidratos, double gorduras, char dataDieta, string refeicao, string alimentos, int quantidade, string observacoes, int usuarioId)
        {
            NomeDieta = nomeDieta;
            TipoDieta = tipoDieta;
            Calorias = calorias;
            Proteinas = proteinas;
            Carboidratos = carboidratos;
            Gorduras = gorduras;
            DataDieta = dataDieta;
            Refeicao = refeicao;
            Alimentos = alimentos;
            Quantidade = quantidade;
            Observacoes = observacoes;
            UsuarioId = usuarioId;
        }
    }
}
