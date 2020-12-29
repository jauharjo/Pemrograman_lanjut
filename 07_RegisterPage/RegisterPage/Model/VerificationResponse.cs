using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPage.Model
{
    class VerificationResponse
    {
        public void OnEmailVerificationSucces(object source, EventArgs e);
        public void OnWhatsaapVerificationSucces(object source, EventArgs e); 
    }
}
