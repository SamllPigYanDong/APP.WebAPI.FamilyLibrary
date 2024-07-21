using Revit.Entity.Commons;
using Revit.Entity.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revit.Entity.Family
{
    public class R_FamilyUser : R_Entity
    {
        /// <summary>
        /// ��ɫId
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// �˵�Id
        /// </summary>
        public long FamilyId { get; set; }


    }
}