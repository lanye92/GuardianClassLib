using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuardianClassLib.Models.MainDb;

namespace GuardianClassLib.BLL
{
    public class UserInfoManage
    {
        private readonly static DAL.MainDbBase _dal = new DAL.MainDbBase();

        public UserInfo Insert(UserInfo ent)
        {
           return _dal.Create(ent);
        }
    }
}
