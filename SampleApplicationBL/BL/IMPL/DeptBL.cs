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
  public  class DeptBL: IDeptBL
    {
        public List<DeptDTO> GetDeptList()
        {
            IDeptDAO _IDeptDAO = new DeptDAO();
            return _IDeptDAO.GetDeptList();
        }
        public List<DeptDTO> GetDepartment(int DeptId)
        {
            IDeptDAO _IDeptDAO = new DeptDAO();
            return _IDeptDAO.GetDepartment( DeptId);
        }
        public long SaveDepartment(DeptDTO ObjDeptDTO)
        {


            IDeptDAO _IDeptDAO = new DeptDAO();
            return _IDeptDAO.SaveDepartment(ObjDeptDTO);
        }
    }
}
