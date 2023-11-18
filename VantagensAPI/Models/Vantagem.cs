using System.ComponentModel.DataAnnotations;

namespace VantagensAPI.Models
{
    public class Vantagem
    {
        public  int IdVantagem { get; set; }
        [Required(ErrorMessage = "O Tipo da Vantagem é obrigatório!")]
        public TipoDeVantagem TipoVantagem { get; set; }
        [Required(ErrorMessage = "O Nome da Vantagem é obrigatório!")]
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public string? Descricao { get; set; }
    }
}