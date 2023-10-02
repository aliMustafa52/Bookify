﻿namespace Bookify.web.Core.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage =Errors.MaxLength) , Display(Name = "Category")]
        [Remote("AllowItem", null!, AdditionalFields ="Id", ErrorMessage = Errors.Dublicated)]
        public string Name { get; set; } = null!;
    }
}
