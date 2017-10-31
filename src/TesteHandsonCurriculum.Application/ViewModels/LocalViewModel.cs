using System.ComponentModel.DataAnnotations;

namespace TesteHandsonCurriculum.Application.ViewModels
{
    public class LocalViewModel
    {
        public LocalViewModel()
        {
            LocalCod = 0;
        }
        [Key]
        public int LocalCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string LocalNome { get; set; }
    }
}