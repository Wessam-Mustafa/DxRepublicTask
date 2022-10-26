using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE.DTO.Parent;
using CORE.Shared;
using static CORE.Shared.Enums;

namespace BLL.Services.Interfaces
{
    public interface IParentService
    {
        APIResponse Add(ParentInput parentInput);
        APIResponse Update(ParentInput parentInput);
        APIResponse Delete(int parentId);
        APIResponse GetOne(int parentId);
        APIResponse GetAll();
        APIResponse GetByParentNationalId(string nationalId);
        APIResponse GetByStudentName(string studentName);
        APIResponse GetByStudentGender(Gender gender);
        APIResponse GetByStudentAgeRange(int startAge, int endAge);
    }
}
