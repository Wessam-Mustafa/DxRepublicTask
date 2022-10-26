using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CORE.Shared.Enums;

namespace CORE.DTO.Parent
{
    public class ParentInput
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "StudentName Is Required")]
        [StringLength(50, ErrorMessage = "StudentName should not be more than 50 letters")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "StudentAge Is Required")]
        public int StudentAge { get; set; }
        [Required(ErrorMessage = "StudentNationalId Is Required")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "NationalId must be 14 Numbers only")]
        public string StudentNationalId { get; set; }
        [Required(ErrorMessage = "StudentGender Is Required")]
        public Gender StudentGender { get; set; }
        [Required(ErrorMessage = "ParentName Is Required")]
        [StringLength(50, ErrorMessage = "ParentName should not be more than 50 letters")]
        public string ParentName { get; set; }
        [Required(ErrorMessage = "ParentAddress Is Required"), StringLength(50)]
        public string ParentAddress { get; set; }
        [Required(ErrorMessage = "ParentPhone is required"), Phone]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone must be 11 Numbers only")]
        public string ParentPhone { get; set; }
        [Required(ErrorMessage = "ParentEmail Is Required"), EmailAddress]
        public string ParentEmail { get; set; }
        [Required(ErrorMessage = "ParentName Is Required")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "NationalId must be 14 Numbers only")]
        public string ParentNationalId { get; set; }
    }
}
