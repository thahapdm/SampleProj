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
using System.Data.Entity;

namespace SampleApplicationDAO.DAO.IMPL
{
  public  class DeptDAO: IDeptDAO
    {
        public DeptDAO()
        {
            
        }

        public List<DeptDTO> GetDeptList()
        {

            List<DeptDTO> _DeptList = new List<DeptDTO>();

           

            using (var context = new SampleDB())
            {
                var Data = context.M_DeptTable.ToList();
                Mapper.CreateMap<M_DeptTable, DeptDTO>();
                Mapper.Map< List<M_DeptTable>, List<DeptDTO>>(Data, _DeptList);
            }




            return _DeptList;
        }

        public List<DeptDTO> GetDepartment(int DeptId)
        {

            List<DeptDTO> _DeptList = new List<DeptDTO>();



            using (var context = new SampleDB())
            {
                var Data = context.M_DeptTable.Where(b => b.DeptId == DeptId).ToList();
                Mapper.CreateMap<M_DeptTable, DeptDTO>();
                Mapper.Map<List<M_DeptTable>, List<DeptDTO>>(Data, _DeptList);
            }




            return _DeptList;
        }

        public long SaveDepartment(DeptDTO ObjDeptDTO)
        {
            long DeptID = 0;
            M_DeptTable ObjDptTable = new M_DeptTable();

            Mapper.CreateMap<DeptDTO ,M_DeptTable >();
            Mapper.Map< DeptDTO,M_DeptTable > (ObjDeptDTO, ObjDptTable);
            if (ObjDptTable != null)
            {

                using (var context = new SampleDB())
                {
                    var result = context.M_DeptTable.SingleOrDefault(b => b.DeptId == ObjDptTable.DeptId);
                    if (result != null)
                    {
                        try
                        {
                            using (var context1 = new SampleDB())
                            {
                                context1.M_DeptTable.Attach(ObjDptTable);
                                context1.Entry(ObjDptTable).State = EntityState.Modified;
                                context1.SaveChanges();
                                DeptID = ObjDptTable.DeptId;
                            }

                            
                             
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    else
                        DeptID = 0;

                }
            }




            return DeptID;
        }
    }
}
