using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Services.Interfaces;
using CORE.DAL;
using CORE.Data;
using CORE.DTO.Parent;
using CORE.Shared;

namespace BLL.Services
{
    public class ParentService : IParentService
    {
        readonly IRepository repository;
        readonly IMapper mapper;

        public ParentService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        public APIResponse Add(ParentInput parentInput)
        {
            try
            {
                if (parentInput is null)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 400,
                        Message = "Please verify your input data"
                    };
                }

                var newParent = mapper.Map<Parent>(parentInput);
                repository.Insert(newParent);

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Message = "Parent added successfully",
                    Data = mapper.Map<ParentOutput>(newParent)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse Update(ParentInput parentInput)
        {
            try
            {
                var parent = repository.GetById(parentInput.Id);
                if (parent is null)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parent not found"
                    };
                }

                var updatedParent = mapper.Map<Parent>(parentInput);
                repository.Update(updatedParent);

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Message = "Parent updated successfully",
                    Data = mapper.Map<ParentOutput>(updatedParent)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse Delete(int parentId)
        {
            try
            {
                repository.Delete(parentId);

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Message = "Parent Deleted successfuly",
                    Data = mapper.Map<List<ParentOutput>>(repository.Get())
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetOne(int parentId)
        {
            try
            {
                var parent = repository.GetById(parentId);
                if (parent is null)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parent not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<ParentOutput>(parent)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetAll()
        {
            try
            {
                var parents = repository.Get();
                if (parents == null || parents.Count() == 0)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parents not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<List<ParentOutput>>(parents)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetByStudentAgeRange(int startAge, int endAge)
        {
            try
            {
                var parents = repository
                    .Get(x => x.StudentAge >= startAge && x.StudentAge <= endAge);
                if (parents == null || parents.Count() == 0)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parents not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<List<ParentOutput>>(parents)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetByStudentGender(Enums.Gender gender)
        {
            try
            {
                var parents = repository.Get(x => x.StudentGender == gender);
                if (parents == null || parents.Count() == 0)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parents not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<List<ParentOutput>>(parents)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetByStudentName(string studentName)
        {
            try
            {
                var parents = repository
                    .Get(x => x.StudentName.Contains(studentName));
                if (parents == null || parents.Count() == 0)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parents not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<List<ParentOutput>>(parents)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }

        public APIResponse GetByParentNationalId(string nationalId)
        {
            try
            {
                var parent = repository
                    .GetFirstOrDefault(x => x.ParentNationalId == nationalId);
                if (parent is null)
                {
                    return new APIResponse
                    {
                        IsError = true,
                        Code = 404,
                        Message = "Parent not found"
                    };
                }

                return new APIResponse
                {
                    IsError = false,
                    Code = 200,
                    Data = mapper.Map<ParentOutput>(parent)
                };
            }
            catch (Exception ex)
            {
                return new APIResponse
                {
                    IsError = true,
                    Code = 500,
                    Message = ex.Message
                };
            }
        }
    }
}
