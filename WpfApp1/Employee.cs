using System;

namespace WpfApp1{
    public class Employee{
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string type { get; set; }

        public Employee (int EmployeeID, string Name, string type) {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.type = type;
        }

        public Employee () {
            
        }
        
    }
}