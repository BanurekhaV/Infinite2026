using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPrj_NUnit
{
    public class User
    {
        public Boolean IsAdmin { get; set; }    
    }

    public class Reservation
    {
        public User bookedBy { get; set; }

        public bool Canbe_CancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;
            if(bookedBy == user)
                return true;
            return false;
        }
    }
}
