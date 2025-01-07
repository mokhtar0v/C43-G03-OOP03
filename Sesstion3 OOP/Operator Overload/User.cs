using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesstion3_OOP.Operator_Overload
{
    // model: is a class represented a data in a table
    class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecuirityStmp { get; set; }

    }
}
