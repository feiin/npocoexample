using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.BLL
{
    public partial class UserRole
    {
        private DAL.UserRole dal =  new  DAL.UserRole();

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

        public Model.UserRole Add(Model.UserRole mUserRole)
        {
            return dal.Add(mUserRole);
        }

        public Model.UserRole Update(Model.UserRole mUserRole)
        {
            return dal.Update(mUserRole);
        }
        
        public Model.UserRole GetUserRole(long userId,long roleId)
        {
            return GetUserRole(userId,roleId);
        }
        
        
        public bool Delete(long userId,long roleId)
        {
            return dal.Delete(userId,roleId);
        }
        

        public List<Model.UserRole> GetList(int count)
        {
            return dal.GetList(count);
        }

        public Page<Model.UserRole> GetPageList(int pageIndex,int pageSize)
        {
            return dal.GetPageList(pageIndex,pageSize);
        }
        /*
        public Page<Model.UserRole> GetPageList(Model.QueryUserRole query)
        {
            return dal.GetPageList(query);
        }
        */

    }

}