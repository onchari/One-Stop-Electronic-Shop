using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneStopElectronix.Areas.Admin.Models
{
    public class MainCategory
    {
        public int MainCategoryId { get; set; }

        [Display(Name = "Category Name")]
        public string MainCategoriesName { get; set; }

        [Display(Name ="Category Description")]
        public string MainCategoriesDescription { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}