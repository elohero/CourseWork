using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class VisitModel
    {
        public string Username { get; set; }
        public string Lesson { get; set; }
        public string Date { get; set; }

        public VisitModel() { }

        public VisitModel(string username, string lesson, string date)
        {
            Username = username;
            Lesson = lesson;
            Date = date;
        }
    }
}
