using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageExample.Model;

namespace RazorPageExample.Pages
{
    public class ServicesModel : PageModel
    {
        public List<Service> Services { get; set; }

        public void OnGet()
        {
            Services = new List<Service>
            {
                new Service { Id = 1, Name = "Web Development", Description = "Building responsive websites.", Price = "$500" },
                new Service { Id = 2, Name = "Mobile App Development", Description = "Creating Android & iOS apps.", Price = "$1000" },
                new Service { Id = 3, Name = "SEO Optimization", Description = "Improving website ranking.", Price = "$300" }
            };
        }
    }
}
