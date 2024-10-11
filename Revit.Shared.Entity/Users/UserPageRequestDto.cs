using Revit.Shared.Entity.Commons.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Users
{
    /// <summary>
    /// 用户翻页请求
    /// </summary>
    public class UserPageRequestDto : PageRequestDto
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserName { get; set; }
    }
}
