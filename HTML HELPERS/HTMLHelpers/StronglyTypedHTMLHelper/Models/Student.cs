using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StronglyTypedHTMLHelper.Models
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
        public string City { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
            
    }
}
