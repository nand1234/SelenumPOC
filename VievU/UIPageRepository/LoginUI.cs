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
            return "Id";
        }
        public String GetPasswordLocatorType()
        {
            return "Id";
        }

        public String GetUserNameLocatorvalue()
        {
            return "Login";
        }
        public String GetPasswordLocatorvalue()
        {
            return "Password";
        }

        public String Submitlocatortype()
        {
            return "CssSelector";
        }
        public String SubmitlocatorValue()
        {
            return "input[type=submit]";
        }
    }

}

    
