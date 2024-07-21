using Revit.Entity.Commons;
using Revit.Entity.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revit.Entity.Family
{
    public class R_FamilyCategory : R_Entity
    {
        /// <summary>
        /// ���Id
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// ��Id
        /// </summary>
        public long FamilyId { get; set; }


    }
}