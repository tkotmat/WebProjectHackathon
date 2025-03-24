namespace WebProjectHackathon.Models
{
    public class ApplicationHandlerModel
    {
        public List<string> name { get; set; }


        public int GetHandlerCount()
        {
            return name.Count;
        }
        public string GetHandlerAiAssistant(int count)
        {
            if (count > 2)
            {
                return "Вы отличный фронтенд-разработчик! Ваши знания охватывают все важные аспекты, включая HTML, CSS, JavaScript, фреймворки, Git, оптимизацию и тестирование. " +
                     "Вы готовы работать над сложными проектами и разрабатывать масштабируемые, производительные веб-приложения.\n" +
                     "С такими навыками вы можете работать на должности Senior Frontend Developer, Lead Frontend Developer, или Full Stack Developer..."; ;
            }
            else if (count > 4)
            {
                return "";
            }
            else if (count > 5)
            {
                return "";
            }
            else if (count > 6)
            {
                return "";
            }
            return "";
        }
    }
}
