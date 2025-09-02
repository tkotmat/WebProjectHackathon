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

        public MainPanelContextEntity? mainPanelContextEntity;
    }
}
