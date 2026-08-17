using System.ComponentModel.DataAnnotations;

namespace PharmacySrenity.Modules.Product.Product;

public enum Gender
{
    [Display(Name ="مردانه")]
    Male = 1,
    [Display(Name = "زنانه")]
    Female = 2
}

