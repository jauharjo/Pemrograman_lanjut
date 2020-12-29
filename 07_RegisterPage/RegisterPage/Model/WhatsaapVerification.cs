using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPage.Model
{
    class WhatsaapVerification
    {
        public event EventHandler WhatsappVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
            WhatsaapVerificationEvent(this, EventArgs.Empty);
        }
    }
}
