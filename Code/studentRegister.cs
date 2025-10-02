using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class studentRegister : Register
    {
        public string studID;

        public studentRegister(string name, string surname, string age, string studID) :base (name, surname, age)
        {
            this.studID = studID;
        }
        public string StudID { get; set; }

        public override string LSRegister()
        {
            return "Name: " + name + " |Surname: " + surname + " |Age: " + age + " |Student ID: " + studID;
            
        }
    }
}
