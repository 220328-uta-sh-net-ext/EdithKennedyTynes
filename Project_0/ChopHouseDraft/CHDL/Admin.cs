using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHDL
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Admin()
        {
            FirstName = "Jane";
            LastName = "Doe";
            Id = 00001;
        }
    }
  
}
