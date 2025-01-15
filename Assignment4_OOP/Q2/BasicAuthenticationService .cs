using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public String[] Username = {"Eman" , "Amira"};
        public String[] Paswword = {"123" , "456"};
        public String[] Role = { "Administrator", "RegularUser" };
       
        public bool AuthenticateUser(string username, string password)
        {
       
                for (int i = 0; i < Username.Length; i++)
                {
                    if (username == Username[i] && password == Paswword[i])
                    {
                        return true;
                    }
                    
            }
            return false;


        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < Username.Length; i++)
            {
                if (username == Username[i] && role == Role[i] )
                {
                    return true;
                }
                
            }
            return false;


        }
    }

}
