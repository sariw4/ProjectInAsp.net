using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Medicine> Drugs { get; set; }
    }
}
