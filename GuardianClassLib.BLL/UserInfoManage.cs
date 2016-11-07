using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuardianClassLib.Models.MainDb;
using GuardianClassLib.Models.MainDb.Activity;

namespace GuardianClassLib.BLL
{
    public class UserInfoManage
    {
        private readonly static DAL.MainDbBase _dal = new DAL.MainDbBase();

        public UserInfo Insert(UserInfo ent)
        {
           return _dal.Create(ent);
        }

        public RequestActivity Create(RequestActivity act)
        {
            return _dal.Create(act);
        }
    }
}
