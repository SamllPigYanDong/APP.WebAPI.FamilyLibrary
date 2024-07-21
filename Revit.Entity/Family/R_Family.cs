using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revit.Entity.Family
{
    public class R_Family : R_File
    {

        [Comment("����ͼ")]
        public Uri MainPhotoUrl { get; set; }

        [Comment("��״̬")]
        public FamilyAuditStatus FamilyAuditStatus { get; set; }=FamilyAuditStatus.Auditing;

        public static R_Family Create(long id,long sameFileKey, long fileSizeInBytes, string fileName, string fileSHA256Hash, Uri familyUrl, Uri imageUrl)
        {
            R_Family item = new R_Family()
            {
                Id = id,
                SameFileKey = sameFileKey,
                Name = fileName,
                FileExtension = Path.GetExtension(fileName),
                SaveUrl = familyUrl,
                MainPhotoUrl = imageUrl,
                FileBytesSize = fileSizeInBytes,
            };
            return item;
        }
    }

    /// <summary>
    /// ��״̬
    /// </summary>
    public enum FamilyAuditStatus
    {
        /// <summary>
        /// �����ϴ�
        /// </summary>
        Auditing = 0,
        /// <summary>
        /// ͨ��
        /// </summary>
        Pass = 1,
        /// <summary>
        /// δͨ��
        /// </summary>
        NotPass = 2,
        /// <summary>
        /// �����
        /// </summary>
        Retry=3
    }
}