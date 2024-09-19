using System.ComponentModel.DataAnnotations;
namespace Aula14DAAWW.Models
{
    public class Jogo
    {
        public int Id { get; set; }

        //REQUIRED = OBRIGUE QUE A PESSOA DIGITE UMA INFORMAÇÃO QUANDO TIVER CADASTRANDO
        //DISPLAY = INDICA O QUE O USUARIO TEM QUE DIGITAR
        [Required] 
        [Display(Name = "Nome do Jogo")] 
        public string NomeJogo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Dt. Lançamento")]

        public DateTime DtLancamento { get; set; }

        [Display(Name = "Link da Imagem")]
        [DataType(DataType.ImageUrl)]
        public string LinkImagem { get; set; }
    }
}
