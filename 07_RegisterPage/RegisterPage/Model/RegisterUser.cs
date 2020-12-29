using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPage.Model
{
    class RegisterUser
    {
        public event EventHandler registerUserEvent;
        public void RegusterAUser()
        {
            Console.WriteLine("User Registered !");
            if(registerUserEvent != null)
            {
                registerUserEvent(this, EventArgs.Empty);
            }
        }
    }
}
