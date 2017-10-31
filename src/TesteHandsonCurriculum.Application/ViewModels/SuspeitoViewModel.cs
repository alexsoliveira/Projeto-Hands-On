using System.ComponentModel.DataAnnotations;

namespace TesteHandsonCurriculum.Application.ViewModels
{
    public class SuspeitoViewModel
    {
        public SuspeitoViewModel()
        {
            SuspeitoCod = 0;
        }
        [Key]
        public int SuspeitoCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SuspeitoNome { get; set; }
    }
}