using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectRequestDto : PageRequestBase
    {
        //删除
        public long UserId { get; set; }

        public AccountDto UserDto { get; set; }

        public int ProjectUserCount { get; set; }

        public double DocumentsSize { get; set; }
    }
}
