using GuardianClassLib.HELPER;
using GuardianClassLib.Models.MainDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.DAL
{
    public class MainDbBase
    {
        private readonly static Models.MainDbContext db = new Models.MainDbContext();

        public UserInfo Create(UserInfo ent)
        {
            db.UserInfo.Add(ent);
            db.SaveChanges();
            return ent;
        }

        public void Delete(UserInfo ent)
        {
            var info = db.UserInfo.Find(ent.PkId);
            db.UserInfo.Remove(info);
            db.SaveChanges();
        }

        public UserInfo Update(UserInfo ent)
        {
            var oe = db.UserInfo.Find(ent.PkId);
            if (oe == null) return null;
            ModelHelper.SetModal(ent, oe);
            db.SaveChanges();
            return oe;
        }
    }
}
