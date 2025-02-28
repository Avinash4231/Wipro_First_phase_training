using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    public class CEmp : ISalaryDetails, APersonalDetails
    {
        private string panDetails;

        public void LastDrawn()
        {
            Console.WriteLine("Last drawn salary for CEmp is: $4000");
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
