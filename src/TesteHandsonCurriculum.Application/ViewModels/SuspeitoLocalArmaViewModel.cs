using System.ComponentModel.DataAnnotations;

namespace TesteHandsonCurriculum.Application.ViewModels
{
    public class SuspeitoLocalArmaViewModel
    {
        public SuspeitoLocalArmaViewModel()
        {
            SuspeitoCod = 0;
            LocalCod = 0;
            ArmaCod = 0;
        }

        [Key]
        public int SuspeitoCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SuspeitoNome { get; set; }

        [Key]
        public int LocalCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string LocalNome { get; set; }

        [Key]
        public int ArmaCod { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string ArmaNome { get; set; }

    }
}
