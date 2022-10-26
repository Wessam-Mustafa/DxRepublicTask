using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CORE.Shared.Enums;

namespace CORE.DTO.Parent
{
    public class ParentOutput
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentNationalId { get; set; }
        public Gender StudentGender { get; set; }
        public string ParentName { get; set; }
        public string ParentAddress { get; set; }
        public string ParentPhone { get; set; }
        public string ParentEmail { get; set; }
        public string ParentNationalId { get; set; }
    }
}
