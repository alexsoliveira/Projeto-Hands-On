namespace TesteHandsonCurriculum.UI.Web.Models
{
    public class MessageViewModel
    {
        public MessageViewModel()
        {
            TituloMessage = "";
            CorpoMessage = "";
        }

        public string TituloMessage { get; set; }
        public string CorpoMessage { get; set; }
    }
}