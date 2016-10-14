using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace GuardianClassLib.Models.MainDb
{
    [Table("UserInfoes")]
    public class UserInfo
    {
        [Key]
        public Guid PkId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
