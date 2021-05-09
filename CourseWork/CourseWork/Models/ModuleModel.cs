using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class ModuleModel
    {
        public string Lesson { get; set; }
        public string Date { get; set; }

        public ModuleModel() { }

        public ModuleModel(string lesson, string date)
        {
            Lesson = lesson;
            Date = date;
        }
    }
}
