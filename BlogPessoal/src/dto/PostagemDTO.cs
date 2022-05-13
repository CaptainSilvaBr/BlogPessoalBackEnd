using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.dtos
{
    
    public class NovaPostagemDTO
    {
        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [Required, StringLength(30)]
        public string EmailCriador { get; set; }

        [Required]
        public string DescricaoTema { get; set; }

        public NovaPostagemDTO(string titulo, string descricao, string foto, string emailCriador, string descricaoTema)
        {
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            EmailCriador = emailCriador;
            DescricaoTema = descricaoTema;
        }
    }

    
    public class AtualizarPostagemDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [Required]
        public string DescricaoTema { get; set; }

        public AtualizarPostagemDTO(int id, string titulo, string descricao, string foto, string descricaoTema)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            DescricaoTema = descricaoTema;
        }
    }
}