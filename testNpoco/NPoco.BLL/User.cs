using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.BLL
{
    public partial class User
    {
        private DAL.User dal =  new  DAL.User();

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

        public Model.User Add(Model.User mUser)
        {
            return dal.Add(mUser);
        }

        public Model.User Update(Model.User mUser)
        {
            return dal.Update(mUser);
        }
        
        public Model.User GetUser(long id)
        {
            return GetUser(id);
        }
        
        
        public bool Delete(long id)
        {
            return dal.Delete(id);
        }
        

        public List<Model.User> GetList(int count)
        {
            return dal.GetList(count);
        }

        public Page<Model.User> GetPageList(int pageIndex,int pageSize)
        {
            return dal.GetPageList(pageIndex,pageSize);
        }
        /*
        public Page<Model.User> GetPageList(Model.QueryUser query)
        {
            return dal.GetPageList(query);
        }
        */

    }

}