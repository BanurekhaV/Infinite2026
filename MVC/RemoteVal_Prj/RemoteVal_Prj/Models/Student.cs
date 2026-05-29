using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteVal_Prj.Models
{
    public class Student
    {
        public string Name { get; set; }

        [Remote("IsMailExist","Student",ErrorMessage ="Email exists, use another..")]
        public string Email { get; set; }

    }
}