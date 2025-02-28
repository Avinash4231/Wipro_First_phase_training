using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    public class PEmp : ISalaryDetails, APersonalDetails
    {
        private string panDetails;

        public void LastDrawn()
        {
            Console.WriteLine("Last drawn salary for PEmp is: $5000");
        }

        public string GetAPanDetails()
        {
            return panDetails;
        }

        public void SetAPanDetails(string panDetails)
        {
            this.panDetails = panDetails;
        }

        
    }
}
