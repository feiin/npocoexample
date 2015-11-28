using System;
using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NPoco.DAL
{
    public partial class UserRole
    {
        private NPoco.PetaPocoDb db =  NPoco.PetaPocoDb.GetInstance();

        public PetaPoco.Transaction GetTransactionScope()
        {
            return db.GetTransaction();
        }

        public Model.UserRole Add(Model.UserRole mUserRole)
        {
            var result = db.Insert(mUserRole);
            return mUserRole;
        }

        public Model.UserRole Update(Model.UserRole mUserRole)
        {
            var result = db.Update(mUserRole);
            return mUserRole;
        }
        
        public Model.UserRole GetUserRole(long userId,long roleId)
        {
            var sql="SELECT * FROM `UserRole` WHERE UserId=@0  AND RoleId=@1 ";
            return db.SingleOrDefault<Model.UserRole>(sql, userId,roleId);
        }
        

        
        public bool Delete(long userId,long roleId)
        {
            var sql="DELETE FROM `UserRole` WHERE UserId=@0  AND RoleId=@1 ";
            db.Execute(sql, userId,roleId);
            return true;
        }
        
        public List<Model.UserRole> GetList(int count)
        {
            var sql="SELECT * FROM `UserRole`  LIMIT 0,@0";
            return db.Query<Model.UserRole>(sql,count).ToList();
        }

        public Page<Model.UserRole> GetPageList(int pageIndex,int pageSize)
        {
            var sql="SELECT * FROM `UserRole`";
            return db.Page<Model.UserRole>(pageIndex,pageSize,sql);
        }

        /*
        public Page<Model.UserRole> GetPageList(Model.QueryUserRole query)
        {
            var sql = new PetaPoco.Sql ();
            sql.Append ("SELECT * FROM  `UserRole`  ");
            sql.Append ("WHERE 1=1");
            //other condition  like: sql.Append(" AND columnName = @0",query.columnName)
            var result = db.Page<Model.UserRole>(query.PageIndex,query.PageSize,sql);
            return result;
        }*/
    }
}