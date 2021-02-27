using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Scaffolding_Template_NorthWind.Models
{
    public partial class Employee
    {
        [NotMapped]
        public String FullName
        {
            get
            {
                return (this.TitleOfCourtesy + " " + this.FirstName + " " + this.LastName);
            }
            set { }
        }

        [NotMapped]
        public String ReportsToEmployee
        {
            get
            {
                var resultado = "Boss";
                if (this.ReportsTo != null) 
                {
                    Employee boss = new Employee();
                    boss.EmployeeId = (int)this.ReportsTo;
                    resultado = this.FullName + " reports to " + boss.FullName;
                }
                return resultado;
            }
            set { }
        }

        [NotMapped]
        public int AgeInYears
        {
            get 
            {
                return (this.BirthDate.Value.Year - DateTime.Now.Year);
            }
            set { }
        }

        public int Antiquity
        {
            get
            {
                return (this.HireDate.Value.Year - DateTime.Now.Year);
            }
            set { }
        }

    }
}
