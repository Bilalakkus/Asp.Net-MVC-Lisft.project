using Admin.project.Models.Base;

namespace Admin.project.Models
{
    public class Menu:BaseEntity
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
        public bool IsItActive { get; set; }
    }
}
