namespace WebProjectHackathon.DataAccess.Entity
{
    public class ContextHomePagesEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public List<CircleContextPagesInfoEntity> CircleContextPagesInfo { get; set; } = new List<CircleContextPagesInfoEntity>();
    }
}
