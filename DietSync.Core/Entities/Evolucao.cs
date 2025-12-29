using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DietSync.Core.Entities
{
    public class Evolucao
    {
        public Evolucao(DateTime data, double peso, double altura, double cintura, int usuarioId)
        {
            Data = data;
            Peso = peso;
            Altura = altura;
            Cintura = cintura;
            UsuarioId = usuarioId;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Cintura { get; set; }

        public int UsuarioId { get; set; }
        public User User { get; set; }

        public void Update(DateTime data, double peso, double altura, double cintura, int usuarioId)
        {
            Data = data;
            Peso = peso;
            Altura = altura;
            Cintura = cintura;
            UsuarioId = usuarioId;
        }
    }
}
