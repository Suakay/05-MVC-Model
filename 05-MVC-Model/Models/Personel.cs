using _10_MVC_Model.Models.Enums;
using _10_MVC_Model.Models.VM;

namespace _10_MVC_Model.Models
{
    public class Personel
    {
        public Personel()
        {
            Department = new Department();
        }
        public int ID { get; set; } 
        public string Name { get; set; }    
        public int DepartmentID {  get; set; }  
        public Department Department { get; set; }
        public DateTime BirthDate { get; set; }
        public WorkingType WorkingType { get; set; }
        public University University { get; set; }  
        public BloodType BloodType { get; set; }
    }
}
