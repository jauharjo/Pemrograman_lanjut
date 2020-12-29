using RegisterPage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPage.Controller
{
    class MainWindowController
    {
        RegisterUser registerUser;
        EmailVerification emailVerification;
        WhatsaapVerification whatsaapVerification;

        public MainWindowController()
        {
            registerUser = new RegisterUser();
            emailVerification = new EmailVerification();
            whatsaapVerification = new WhatsaapVerification();
        }
        public void registeringUser(String nama, string email, String noTelp)
        {
            registerUser.RegusterAUser();
        }
        public void SubscribeEmailVerification()
        {
            registerUser.registerUserEvent += emailVerification.OnUserRegistered;
        }

        internal void SubscribeVerificationResult(MainWindow mainWindow)
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeEmailVerification()
        {
            registerUser.registerUserEvent -= emailVerification.OnUserRegistered;
        }
        public void SubscribeWhatsaapVerification()
        {
            registerUser.registerUserEvent += whatsaapVerification.OnUserRegistered;
        }
        public void UnsubscribeWhatsaapVerification()
        {
            registerUser.registerUserEvent -= whatsaapVerification.OnUserRegistered;
        }

        public void SubscribeVerificationResult(VerificationResponse listener)
        {
            emailVerification.EmailVerificationEvent += listener.OnEmailVerificationSucces;
            whatsaapVerification.WhatsappVerificationEvent += listener.OnWhatsaapVerificationSucces;
        }
    }
}
