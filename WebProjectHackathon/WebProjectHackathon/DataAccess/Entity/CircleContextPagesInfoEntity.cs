namespace WebProjectHackathon.DataAccess.Entity
{
    public class CircleContextPagesInfoEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        
        public int IdContextHomePages { get; set; }
        
        public ContextHomePagesEntity? ContextHomePage { get; set; }

        public List<MainPanelContextEntity> mainPanelContext { get; set; } = new List<MainPanelContextEntity>(); 
    }
}
