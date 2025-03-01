using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExample.Model;

namespace RazorExample.Pages
{
    public class EmployeeModel : PageModel
    {
        public List<EmployeeData> employees { get; set; }
        public void OnGet()
        {
            List<EmployeeData> emp1 = new List<EmployeeData>();
            EmployeeData employeeData = new EmployeeData(1,"John","Male","xyz");
            EmployeeData employeeData2 = new EmployeeData(1, "John", "Male", "xyz");
            EmployeeData employeeData3 = new EmployeeData(1, "John", "Male", "xyz");
            EmployeeData employeeData4 = new EmployeeData(1, "John", "Male", "xyz");


            emp1.Add(employeeData);
            emp1.Add(employeeData2);
            emp1.Add(employeeData3);
            emp1.Add(employeeData4);


            employees = emp1;


        }
    }
}
