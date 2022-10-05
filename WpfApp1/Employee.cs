using System;

namespace WpfApp1{
    public class Employee{
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Employee(int employeeID, string name, string type){
        EmployeeID = employeeID;
        Name = name;
        Type = type;
        }
        
    }
}