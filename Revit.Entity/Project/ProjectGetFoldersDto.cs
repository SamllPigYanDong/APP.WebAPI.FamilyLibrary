using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectGetFoldersDto
    {
        /// <summary>
        /// 项目Id
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// 请求的相对路径
        /// </summary>
        public string RequestPath { get; set; }
    }
}
