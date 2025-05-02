using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVC_Project.Presentation.ViewModels.DepartmentViewModel
{
    public class DepartmentEditViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
