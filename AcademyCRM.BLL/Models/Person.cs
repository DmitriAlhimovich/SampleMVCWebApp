using System;

namespace AcademyCRM.BLL.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}