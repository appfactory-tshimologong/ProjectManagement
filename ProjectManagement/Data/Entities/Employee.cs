using System;

namespace ProjectManagement.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public Address HomeAddress { get; set; }
        public string CellPhoneNo { get; set; }

    }
}
