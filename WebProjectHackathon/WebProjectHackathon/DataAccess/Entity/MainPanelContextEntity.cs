using System.ComponentModel.DataAnnotations;

namespace WebProjectHackathon.DataAccess.Entity
{
    public class MainPanelContextEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Context { get; set; } = string.Empty;
        
        public string Url { get; set; } = string.Empty;

        public int CircleContextPagesInfoEntityId { get; set; }

        public CircleContextPagesInfoEntity? CircleContextPagesInfo { get; set; }
    }
}
