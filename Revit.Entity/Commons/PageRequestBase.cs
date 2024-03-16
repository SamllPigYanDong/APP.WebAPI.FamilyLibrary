using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Commons
{
    public class PageRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SearchMessage { get; set; }
    }
}
