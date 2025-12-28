namespace DietSync.Core.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Meta { get; private set; } = string.Empty;
        public string Sexo { get; private set; } = string.Empty;
        public DateTime DataNasc { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }
        public string Email { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;

        public ICollection<Treino> Treinos { get; set; }
        public ICollection<Dieta> Dietas { get; set; }
        public ICollection<Receita> Receitas { get; set; }
        public ICollection<Evolucao> Evolucoes { get; set; }
    }
}


