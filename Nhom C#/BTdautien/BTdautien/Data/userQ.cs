using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTdautien.Data
{
   public class userQ
    {
      public User user;
       public userQ()
       {
           user = new User() { ID = 1, UserName = "admin", PassWord = "admin", Remember = true };
       }
    }
}
