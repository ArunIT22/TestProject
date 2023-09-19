using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id=1, Name="Arun", MobileNo="9840654358"},
                new Employee{Id=2, Name="Idhaya", MobileNo="6382072208"},
                new Employee{Id=3, Name="Senthil", MobileNo="9788858455"},
            };
        }

    }


}
