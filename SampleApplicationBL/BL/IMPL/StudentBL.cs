using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApplicationObjects.DTO;
using SampleApplicationDAO.DAO;
using SampleApplicationDAO.DAO.IMPL;

namespace SampleApplicationBL.BL.IMPL
{
  public   class StudentBL: IStudentBL
    {
        public List<StudentDTO> GetStudentList (int DeptId)
        {
            IStudentDAO _IStudentDAO = new StudentDAO();
            return _IStudentDAO.GetStudentList( DeptId);
        }
    }
}
