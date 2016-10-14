using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb
{
    public class UserInfo
    {
        [Key]
        public Guid PkId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
