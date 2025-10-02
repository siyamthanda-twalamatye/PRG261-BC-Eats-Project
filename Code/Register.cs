using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class Register
    {
        public string name, surname, age;
        

        public Register(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public virtual string LSRegister()
        {

            return "";
        }
        
    }
}
