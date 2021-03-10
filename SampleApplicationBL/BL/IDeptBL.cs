using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApplicationObjects.DTO;
namespace SampleApplicationBL.BL
{
   public  interface IDeptBL
    {
        List<DeptDTO> GetDeptList();
        List<DeptDTO> GetDepartment(int DeptId);
        long SaveDepartment(DeptDTO ObjDeptDTO);
    }
}
