using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_5_Group_3
{
    class user
    {
        private string username = "admin";
        private string password = "1234";
        private static Dictionary<string, string> users = new Dictionary<string, string>();

        public user() { }
        public user(string Us, string Pass)
        {
            username = Us;
            password = Pass;
            users.Add(Us, Pass);
        }

        public string getUser()
        {
            return username;
        }
        public string getPass()
        {
            return password;
        }
        public Dictionary<string, string> getList()
        {
            return users;

        }
    }
}
