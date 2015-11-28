using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.DAL
{
    public partial class Role
    {
        private NPoco.PetaPocoDb db =  NPoco.PetaPocoDb.GetInstance();

        public PetaPoco.Transaction GetTransactionScope()
        {
            return db.GetTransaction();
        }

        public Model.Role Add(Model.Role mRole)
        {
            var result = db.Insert(mRole);
            mRole.Id = Convert.ToInt64(result);
            return mRole;
        }

        public Model.Role Update(Model.Role mRole)
        {
            var result = db.Update(mRole);
            return mRole;
        }
        
        public Model.Role GetRole(long id)
        {
            var sql="SELECT * FROM `Roles` WHERE Id=@0 ";
            return db.SingleOrDefault<Model.Role>(sql, id);
        }
        

        
        public bool Delete(long id)
        {
            var sql="DELETE FROM `Roles` WHERE Id=@0 ";
            db.Execute(sql, id);
            return true;
        }
        
        public List<Model.Role> GetList(int count)
        {
            var sql="SELECT * FROM `Roles`  LIMIT 0,@0";
            return db.Query<Model.Role>(sql,count).ToList();
        }

        public Page<Model.Role> GetPageList(int pageIndex,int pageSize)
        {
            var sql="SELECT * FROM `Roles`";
            return db.Page<Model.Role>(pageIndex,pageSize,sql);
        }

        /*
        public Page<Model.Role> GetPageList(Model.QueryRole query)
        {
            var sql = new PetaPoco.Sql ();
            sql.Append ("SELECT * FROM  `Roles`  ");
            sql.Append ("WHERE 1=1");
            //other condition  like: sql.Append(" AND columnName = @0",query.columnName)
            var result = db.Page<Model.Role>(query.PageIndex,query.PageSize,sql);
            return result;
        }*/
    }
}