using System;

namespace WpfApp1
{
    public class Employee{
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public EmployeeType type { get; set; }

        public Restaurant resto { get; set; }

        public Employee (string Name, EmployeeType type, Restaurant resto) {
            this.resto = resto;
            this.EmployeeID = Globals.indexEmployee;
            Globals.indexEmployee += 1;
            this.Name = Name;
            this.type = type;
        }

        public Employee () {
            
        }

        public void print (string message)
        {
            // printing message argument in the GUI
        }
        
    }
}