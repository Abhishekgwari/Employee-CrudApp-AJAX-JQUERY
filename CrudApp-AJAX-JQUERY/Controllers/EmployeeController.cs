using Microsoft.AspNetCore.Mvc;
using GE = GlobalEntity;
using BusinessLayer;
using BusinessLayer.Interface;
namespace CrudApp_AJAX_JQUERY.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBC employeeBC;
        public EmployeeController(IEmployeeBC employeeBC) 
        { 
        
        this.employeeBC = employeeBC;
        }
        public async Task<IActionResult> Index()
        {
            List<GE::Employee> employees = new List<GE.Employee>(); // await this.employeeBC.GetEmployees();
            return View(employees);
        }

        public IActionResult Create()
        {
            
            return View(new GE.Employee());
        }

        public async Task<IActionResult> Edit(string code)
        {
            GE::Employee employees = await this.employeeBC.GetEmployeebycode(Convert.ToInt32(code));

            return View("Create",employees);
        }

        public async Task<IActionResult> Save(GE::Employee employee)
        {

            string Response = await this.employeeBC.Save(employee);
            return Json(Response);
        }

        public async Task<IActionResult> Remove(string code)
        {

            string Response = await this.employeeBC.RemoveEmployee(Convert.ToInt32(code));
            return Json(Response);
        }


        public async Task<IActionResult> GetAll(string code)
        {

            var Response = await this.employeeBC.GetEmployees();
            return Json(Response);
        }
    }
}
