using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApplicationObjects.DTO;
namespace SampleApplicationDAO.DAO
{
    public interface IDeptDAO
    {
        List<DeptDTO> GetDeptList();
        List<DeptDTO> GetDepartment(int DeptId);
        long SaveDepartment(DeptDTO ObjDeptDTO);
    }
}
