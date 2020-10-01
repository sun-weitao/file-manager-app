using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace file_manager_app.Models
{
    public class File
    {
        //id
        public virtual int id { get; set; }
        //上传者id
        public virtual int userId { get; set; }
        //文件标题
        public virtual string title { get; set; }
        //路径
        public virtual string url { get; set; }
        //类型 string ? 
        public virtual string type { get; set; }
        //标记 对上传文件标记说明
        public virtual string mark { get; set; }
        //是否是共享文件
        public virtual bool isShared { get; set; } = false;
        //创建时间
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime createTime { get; set; }
    }
}