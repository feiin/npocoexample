using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.DAL
{
    public partial class User
    {
        private NPoco.PetaPocoDb db =  NPoco.PetaPocoDb.GetInstance();

        public PetaPoco.Transaction GetTransactionScope()
        {
            return db.GetTransaction();
        }

        public Model.User Add(Model.User mUser)
        {
            var result = db.Insert(mUser);
            mUser.Id = Convert.ToInt64(result);
            return mUser;
        }

        public Model.User Update(Model.User mUser)
        {
            var result = db.Update(mUser);
            return mUser;
        }
        
        public Model.User GetUser(long id)
        {
            var sql="SELECT * FROM `Users` WHERE Id=@0 ";
            return db.SingleOrDefault<Model.User>(sql, id);
        }
        

        
        public bool Delete(long id)
        {
            var sql="DELETE FROM `Users` WHERE Id=@0 ";
            db.Execute(sql, id);
            return true;
        }
        
        public List<Model.User> GetList(int count)
        {
            var sql="SELECT * FROM `Users`  LIMIT 0,@0";
            return db.Query<Model.User>(sql,count).ToList();
        }

        public Page<Model.User> GetPageList(int pageIndex,int pageSize)
        {
            var sql="SELECT * FROM `Users`";
            return db.Page<Model.User>(pageIndex,pageSize,sql);
        }

        /*
        public Page<Model.User> GetPageList(Model.QueryUser query)
        {
            var sql = new PetaPoco.Sql ();
            sql.Append ("SELECT * FROM  `Users`  ");
            sql.Append ("WHERE 1=1");
            //other condition  like: sql.Append(" AND columnName = @0",query.columnName)
            var result = db.Page<Model.User>(query.PageIndex,query.PageSize,sql);
            return result;
        }*/
    }
}