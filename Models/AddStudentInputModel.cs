using System;

namespace SchoolManager.API.Models
{
    public class AddStudentInputModel
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public string FullAddress { get; set; }
    }
}