using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In
{
    class UsersList
    {
        public List<Users> usersList = new List<Users>();

        public override string ToString()
        {
            return string.Join(" ", usersList);
        }
    }
}
