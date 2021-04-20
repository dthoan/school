using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fifness.Models
{
    public class UserDao
    {
        fifnessEntities db = new fifnessEntities();
        public long Insert(USER entity)
        {
            db.USERs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
       
    }
}