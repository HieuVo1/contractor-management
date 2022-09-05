using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_management.DTOs.Contractor.Request
{
    public class NewContractor
    {
        public string Name { get; set; }
        public string Representative { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int WorkingTime { get; set; }
        public int NumberEmployee { get; set; }
    }
}