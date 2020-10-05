using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace file_manager_app.Models
{
    public class FileViewModel
    {
        [Required]
        [Display(Name ="文件名称")]
        public string title { set; get; }

        [Required]
        [Display(Name = "文件上传")]
        public HttpPostedFileBase file { get; set; }

        [Required]
        [Display(Name = "是否分享")] 
        public int isShared { set; get; } = 0;
    }
}