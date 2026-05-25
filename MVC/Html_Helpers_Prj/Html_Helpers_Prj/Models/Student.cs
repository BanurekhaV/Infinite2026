using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Html_Helpers_Prj.Models
{
    public class Student
    {
        [Display(Name = "Student Roll No ")]
        public int RNo { get; set; }
        [DisplayName("Student Name")]
        public string name {  get; set; }
        [DataType(DataType.MultilineText)]
        public string Address {  get; set; }    
    }
}