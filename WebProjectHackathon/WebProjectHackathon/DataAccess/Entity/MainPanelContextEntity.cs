namespace WebProjectHackathon.DataAccess.Entity
{
    public class MainPanelContextEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Context { get; set; } = string.Empty;
        
        public string Url { get; set; } = string.Empty;

        public int CircleContextPagesInfoEntityId { get; set; }

        public CircleContextPagesInfoEntity? CircleContextPageInfo { get; set; }
    }
}
