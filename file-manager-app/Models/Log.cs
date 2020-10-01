using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace file_manager_app.Models
{
    public class Log
    {
        public virtual int id { get; set; }

        public virtual int userId { get; set; }
        //操作日志
        public virtual string action { get; set; }
        //创建时间
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime createTime { get; set; }
    }
}