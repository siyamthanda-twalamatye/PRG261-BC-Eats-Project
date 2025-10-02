using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class lecturerRegister : Register
    {
        public string empID;

        public lecturerRegister(string name, string surname, string age, string empID) : base(name, surname, age)
        {
            this.empID = empID;
        }
        public string EmpID { get; set; }

        public override string LSRegister()
        {
            return "Name: " + name + " |Surname: " + surname + " |Age: " + age + " |Employee ID " + empID;
        }

        
    }
}
