using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data;
using ProjectManagement.ViewModels;
using System.Linq;

namespace ProjectManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ProjectManagementContext _context;

        public EmployeeController(ProjectManagementContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _context.Employees
            .Select(e => new EmployeeViewModel()
            {
                Id = e.Id,
                FullName = $"{e.Surname}, {e.FirstName}",
                CellPhoneNo = e.CellPhoneNo
            })
            .ToArray();
                
            return View(result);
        }

    }
}
