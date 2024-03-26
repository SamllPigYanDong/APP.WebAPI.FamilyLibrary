using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectCreateFolderDto
    {

        /// <summary>
        /// 创建人Id
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public long CreatorId { get; set; }


        /// <summary>
        /// 请求的相对路径
        /// </summary>
        public string RequestPath { get; set; }


        /// <summary>
        /// 文件夹名称
        /// </summary>
        public string FolderName { get; set; }

    }
}
