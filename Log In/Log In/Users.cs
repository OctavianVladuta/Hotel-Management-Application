using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In
{
    class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public override bool Equals(object obj)
        {
            if (!(obj is Users))
            {
                return false;
            }

            Users users = obj as Users;

            return users.Email == Email && users.Password == Password;
        }


        public override string ToString()
        {
            return $"{Id},{Email},{Password}";
        }
    }
}
