﻿using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectRequestDto : PageRequestBase
    {
        public long UserId { get; set; }
    }
}
