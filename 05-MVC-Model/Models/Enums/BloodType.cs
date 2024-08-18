using System.ComponentModel.DataAnnotations;

namespace _10_MVC_Model.Models.Enums
{
    public enum BloodType
    {
        [Display(Name ="A RH+")]
        ARHP=1,
        [Display(Name = "A RH-")]
        ARHN=2,
        [Display(Name = "B RH+")]
        BRHP = 3,
        [Display(Name = "B RH-")]
        BRHN = 4,
        [Display(Name = "0 RH+")]
        ORHP = 5,
        [Display(Name = "0 RH-")]
        ORHN = 6,
        [Display(Name = "AB RH+")]
        ABRHP,
        [Display(Name = "AB-RH+")]
        ABRHN

    }
}
