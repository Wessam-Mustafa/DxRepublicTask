using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.DAL;
using static CORE.Shared.Enums;

namespace CORE.Data
{
    public class ParentData
    {
        public static List<Parent> Parents = new List<Parent>()
        {
            new Parent{
                Id = 1,
                StudentName = "Ahmed",
                StudentNationalId = "30159972937551",
                StudentAge = 10,
                StudentGender = Gender.Male,
                ParentName = "Omar",
                ParentNationalId = "20153372933791",
                ParentEmail = "parent0@gmail.com",
                ParentPhone = "01010101010",
                ParentAddress = "Giza",
            },
            new Parent{
                Id = 2,
                StudentName = "Khaled",
                StudentNationalId = "30129872132501",
                StudentAge = 13,
                StudentGender = Gender.Male,
                ParentName = "Saleh",
                ParentNationalId = "20192275913724",
                ParentEmail = "parent1@gmail.com",
                ParentPhone = "01011111111",
                ParentAddress = "Alexandria",
            },
            new Parent{
                Id = 3,
                StudentName = "Hend",
                StudentNationalId = "30117382152023",
                StudentAge = 9,
                StudentGender = Gender.Female,
                ParentName = "Magdy",
                ParentNationalId = "20172235317708",
                ParentEmail = "parent2@gmail.com",
                ParentPhone = "01012121212",
                ParentAddress = "Cairo",
            }
        };
    }
}
