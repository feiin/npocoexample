using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.BLL
{
    public partial class Role
    {
        private DAL.Role dal =  new  DAL.Role();

        /*
        public void UsingTransaction()
        {
            using(var scope = dal.GetTransactionScope())
            {
                //TODO.....dal.method1();dal.method2();dal1.method();
                scope.Complete();
            }

        }
        */

        public Model.Role Add(Model.Role mRole)
        {
            return dal.Add(mRole);
        }

        public Model.Role Update(Model.Role mRole)
        {
            return dal.Update(mRole);
        }
        
        public Model.Role GetRole(long id)
        {
            return GetRole(id);
        }
        
        
        public bool Delete(long id)
        {
            return dal.Delete(id);
        }
        

        public List<Model.Role> GetList(int count)
        {
            return dal.GetList(count);
        }

        public Page<Model.Role> GetPageList(int pageIndex,int pageSize)
        {
            return dal.GetPageList(pageIndex,pageSize);
        }
        /*
        public Page<Model.Role> GetPageList(Model.QueryRole query)
        {
            return dal.GetPageList(query);
        }
        */

    }

}