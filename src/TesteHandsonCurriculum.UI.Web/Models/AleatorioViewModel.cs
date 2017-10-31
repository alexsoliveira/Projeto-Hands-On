using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteHandsonCurriculum.UI.Web.Models
{
    public class AleatorioViewModel
    {
        public AleatorioViewModel()
        {
            numeroSuspeito = 0;
            numeroLocal = 0;
            numeroArma = 0;
        }

        public int numeroSuspeito { get; set; }
        public int numeroLocal { get; set; }
        public int numeroArma { get; set; }
    }
}