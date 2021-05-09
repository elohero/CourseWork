using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class StudentModel
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ParrentFullName { get; set; }
        public string LivingInHostel { get; set; }

        public StudentModel() { }

        public StudentModel(string address, string phone, string parrentFullName, string livingInHostel)
        {
            Address = address;
            Phone = phone;
            ParrentFullName = parrentFullName;
            LivingInHostel = livingInHostel;
        }
    }
}
