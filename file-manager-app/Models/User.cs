using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace file_manager_app.Models
{
    public class User
    {
        public virtual int id { get; set; }
        
        public virtual string username { get; set; }

        public virtual string password { get; set; }

        public virtual string nickname { get; set; }

        public virtual string avatar { get; set; }

        public virtual bool isSuperAdmin { get; set; } = false;
        //创建时间
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime createTime { get; set; }
    }
}