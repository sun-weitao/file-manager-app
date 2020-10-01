using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace file_manager_app.Models
{
    public class Folder
    {
        public virtual int id { get; set; }
        //上传者id
        public virtual int userId { get; set; }
        //文件夹名称
        public virtual string title { get; set; }
        //文件夹下的文件
        public virtual List<File> files { get; set; }
        //文件夹下的文件夹
        public virtual List<Folder> folders { get; set; }
        //是否是共享文件
        public virtual bool isShared { get; set; } = false;
        //创建时间
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime createTime { get; set; }
    }
}