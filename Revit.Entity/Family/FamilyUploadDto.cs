using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Family
{
    public class FamilyUploadDto
    {

        public IFormFileCollection Files { get; set; }

        //public List<long> CategoriesIds { get; set; }
    }
}
