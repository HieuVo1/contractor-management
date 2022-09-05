using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_management.DTOs.Contractor.Response
{
    public class GetContractor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Representative { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int WorkingTime { get; set; }
        public int NumberEmployee { get; set; }
    }
}