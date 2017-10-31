using System.ComponentModel.DataAnnotations;

namespace TesteHandsonCurriculum.Application.ViewModels
{
    public class ArmaViewModel
    {
        public ArmaViewModel()
        {
            ArmaCod = 0;
        }
        [Key]
        public int ArmaCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string ArmaNome { get; set; }
    }
}