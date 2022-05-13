using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.dtos
{
    
    public class NovoTemaDTO
    {
        [Required, StringLength(20)]
        public string Descricao { get; set; }
        public NovoTemaDTO(string descricao)
        {
            Descricao = descricao;
        }
    }

    
    public class AtualizarTemaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Descricao { get; set; }
        public AtualizarTemaDTO(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}