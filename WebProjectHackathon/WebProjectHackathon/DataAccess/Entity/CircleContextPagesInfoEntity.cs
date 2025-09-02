using System.ComponentModel.DataAnnotations;

namespace WebProjectHackathon.DataAccess.Entity
{
    public class CircleContextPagesInfoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        
        public int IdContextPagesInfo { get; set; }
        
        public CircleContextPagesInfoEntity? CircleContextPagesInfo { get; set; }

        public List<MainPanelContextEntity> mainPanelContextEntity { get; set; } = new List<MainPanelContextEntity>(); 
    }
}
