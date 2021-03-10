using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApplicationObjects.DTO;
using SampleApplicationObjects;
using SampleApplicationDAO;
using System.Collections;
using AutoMapper;

namespace SampleApplicationDAO.DAO.IMPL
{
  public  class StudentDAO: IStudentDAO
    {
        public List<StudentDTO> GetStudentList(int DeptId)
        {

            List<StudentDTO> _StudentDTOList = new List<StudentDTO>();



            using (var context = new SampleDB())
            {
                var Data = context.M_StudentTable.Where(b => b.DeptId == DeptId).ToList();
                Mapper.CreateMap<M_StudentTable, StudentDTO>();
                Mapper.Map<List<M_StudentTable>, List<StudentDTO>>(Data, _StudentDTOList);
            }




            return _StudentDTOList;
        }
    }
}
