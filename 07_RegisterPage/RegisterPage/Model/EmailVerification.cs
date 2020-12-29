using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPage.Model
{
    class EmailVerification
    {
        public event EventHandler EmailVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
            EmailVerificationEvent(this, EventArgs.Empty);
        }
    }
}
