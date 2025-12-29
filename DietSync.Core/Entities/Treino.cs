namespace DietSync.Core.Entities
{
    public class Treino
    {
        public Treino(DateTime data, string tipo, string exercicios, int repeticoes, int series, string objetivo, int duracao, int frequencia, string nomeTreino, char diaTreino, int usuarioId)
        {
            Data = data;
            Tipo = tipo;
            Exercicios = exercicios;
            Repeticoes = repeticoes;
            Series = series;
            Objetivo = objetivo;
            Duracao = duracao;
            Frequencia = frequencia;
            NomeTreino = nomeTreino;
            DiaTreino = diaTreino;
            UsuarioId = usuarioId;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Exercicios { get; set; }
        public int Repeticoes { get; set; }
        public int Series { get; set; }
        public string Objetivo { get; set; }
        public int Duracao { get; set; }
        public int Frequencia { get; set; }
        public string NomeTreino { get; set; }
        public char DiaTreino { get; set; }

        public int UsuarioId { get; set; }
        public User User { get; set; }

        public void Update(DateTime data, string tipo, string exercicios, int repeticoes, int series, string objetivo, int duracao, int frequencia, string nomeTreino, char diaTreino, int usuarioId)
        {
            Data = data;
            Tipo = tipo;
            Exercicios = exercicios;
            Repeticoes = repeticoes;
            Series = series;
            Objetivo = objetivo;
            Duracao = duracao;
            Frequencia = frequencia;
            NomeTreino = nomeTreino;
            DiaTreino = diaTreino;
            UsuarioId = usuarioId;
        }
    }
}