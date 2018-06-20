using System.ComponentModel.DataAnnotations;

namespace OneStopElectronix.Areas.Admin.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Display(Name ="Subcategory Name")]
        public string SubCategoryName { get; set; }

        [Display(Name ="Description")]
        public string SubCategoryDescription { get; set; }

        public int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
    }
}