using Microsoft.AspNetCore.Mvc;

namespace Bookify.web.Core.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage ="Max length cannot be more than 100 char.")]
        [Remote("AllowItem",null,AdditionalFields ="Id",ErrorMessage ="Category name is already exists")]
        public string Name { get; set; } = null!;
    }
}
