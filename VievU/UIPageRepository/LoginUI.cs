using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VievU.UIPageRepository
{
    class LoginUI 
    {
       public String GetUserNameLocatorType()
        {
            return "email";
        }
        public String GetPasswordLocatorType()
        {
            return "pass";
        }

        public String GetUserNameLocatorvalue()
        {
            return "Nandkumar.ghtage@facebook.com";
        }
        public String GetPasswordLocatorvalue()
        {
            return "Password@123";
        }
    }

}

    
