﻿using GuardianClassLib.HELPER;
using GuardianClassLib.Models.MainDb;
using GuardianClassLib.Models.MainDb.Activity;
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

        #region UserInfo增删改查


        public UserInfo Create(UserInfo ent)
        {
            db.UserInfos.Add(ent);
            db.SaveChanges();
            return ent;
        }

        public void Delete(UserInfo ent)
        {
            var info = db.UserInfos.Find(ent.PkId);
            db.UserInfos.Remove(info);
            db.SaveChanges();
        }

        public UserInfo Update(UserInfo ent)
        {
            var oe = db.UserInfos.Find(ent.PkId);
            if (oe == null) return null;
            ModelHelper.SetModal(ent, oe);
            db.SaveChanges();
            return oe;
        }

        public IQueryable<UserInfo> GetQueryableUserInfo => db.UserInfos.AsNoTracking();
        #endregion

        #region Activity增删改查

        public RequestActivity Create(RequestActivity act)
        {
            db.RequestActivity.Add(act);
            db.SaveChanges();
            return act;
        }
        #endregion

    }
}
