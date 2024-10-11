using Revit.Shared.Entity.Commons.Page;

namespace Revit.Shared.Entity.Project
{
    public class ProjectPageRequestDto : PageRequestDto
    {
        //删除
        public long UserId { get; set; }

    }
}
