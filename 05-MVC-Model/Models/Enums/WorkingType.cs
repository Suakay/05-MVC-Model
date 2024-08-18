using System.ComponentModel.DataAnnotations;

namespace _10_MVC_Model.Models.Enums
{
    public enum WorkingType
    {
        [Display(Name ="Tam Zamanlı")]
        FullTime=1,
        [Display(Name ="Yarı zamanlı")]
        PartTime=2,
        [Display(Name ="Proje Bazlı")]
        ProjectBased=3,
        [Display(Name ="Serbest Zamanlı")]
        Freelance=4
        
    }
}
