using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class R_ProjectFolder:R_Entity
    {
        [Comment("文件名称无后缀")]
        public string Name { get; set; } = "";

        [Comment("后缀名称")]
        public string FileExtension { get; set; } = "";


        [Comment("文件大小")]
        public string FileSize { get; set; } = "";



        [Comment("项目Id")]
        public long ProjectId { get; set; }


        [Comment("相对路径")]
        public string RelativePath { get; set; } = "";


        [Comment("是否为根路径")]
        public bool IsRoot { get; set; }

    }
}
