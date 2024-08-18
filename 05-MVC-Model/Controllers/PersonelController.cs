using _10_MVC_Model.Models;
using _10_MVC_Model.Models.VM;
using Microsoft.AspNetCore.Mvc;

namespace _10_MVC_Model.Controllers
{
    public class PersonelController : Controller
    {
        List<Personel> personeller = new List<Personel>()
        {
            new Personel(){ID=1, Name="Bilge Adam", BirthDate=new DateTime(2000,01,01),WorkingType=Models.Enums.WorkingType.FullTime},
             new Personel(){ID=1, Name="Ayşe Fatma", BirthDate=new DateTime(2000,01,01),WorkingType=Models.Enums.WorkingType.PartTime},
              new Personel(){ID=1, Name="Hayriye Nuriye", BirthDate=new DateTime(2000,01,01),WorkingType=Models.Enums.WorkingType.ProjectBased},
               new Personel(){ID=1, Name="Ali Veli", BirthDate=new DateTime(2000,01,01),WorkingType=Models.Enums.WorkingType.Freelance },
        };
        List<Department> department = new List<Department>()
        {
            new Department(){ID=1,DepartmentName="Yazılım"},
            new Department(){ID=2,DepartmentName="Muhasebe"},
            new Department(){ID=3,DepartmentName="Donanım"},
            new Department(){ID=4,DepartmentName="IT"},
            new Department(){ID=5,DepartmentName="IK"},
        };
        List<University> universities = new List<University>()
        {
            new University(){ID=1,Name="Işık"},
            new University(){ID=2,Name="Bahçesehir"},
            new University(){ID=3,Name="Kültür"},
            new University(){ID=4,Name="Nişantaşı"},
            new University(){ID=5,Name="Beykentt"},
        };
        public PersonelController() { }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            //return View(department);//departmanı çek view a model olarak gönder.
            CreateVM vm =new CreateVM();
            vm.Personel = new Personel();
            vm.Departments = new List<Department>();
            vm.Universities = new List<University>();   
                return View(vm);


            
        }
        [HttpPost]
        public IActionResult Craate(Personel personel)
        {
            personel.ID = personeller.Count + 1;
            personeller.Add(personel);
            return View("Index",personeller);
        }
    }
}
