using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleApplicationObjects.DTO;
using SampleApplicationBL.BL;
using SampleApplicationBL.BL.IMPL;
namespace SampleApplication.Controllers
{
    public class DeptController : Controller
    {
      
        public DeptController()
        {
           

        }
        
        public ActionResult Index()
        {
            


          return View("~/Views/Dept/Index.cshtml");
        }

        public ActionResult GetDeptList()
        {
            IDeptBL _IDeptBL = new DeptBL();
            List<DeptDTO> _DeptList = _IDeptBL.GetDeptList();
            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = _DeptList
            };
        }

        public ActionResult GetStudentList(int DeptId)
        {
            IStudentBL _IStudentBL = new StudentBL();
            
            List<StudentDTO> _StudentDTOList = _IStudentBL.GetStudentList( DeptId);
            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = _StudentDTOList
            };
        }

        public ActionResult GetDepartment(int DeptId)
        {
            IDeptBL _IDeptBL = new DeptBL();
            List<DeptDTO> _DeptList = _IDeptBL.GetDepartment(DeptId);
            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = _DeptList
            };
        }

        public ActionResult SavedDepartments(DeptDTO DepartmentObj )
        {
           
            IDeptBL _IDeptBL = new DeptBL();
           long DeptID = _IDeptBL.SaveDepartment(DepartmentObj);
            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = DeptID
            };
        }
    }
}