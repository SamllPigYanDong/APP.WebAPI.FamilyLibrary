using Revit.Entity.Commons;
using Revit.Entity.Family;
using Revit.Shared.Entity.Commons.Page;
using Revit.Shared.Entity.Family;

namespace Revit.Service.Families
{
    public interface IFamilyService
    {
        Task<IEnumerable<FamilyDto>> GetFamiliesByUser(long userId);
        Task<IPagedList<FamilyDto>> GetListAsync(FamilyPageRequestDto parameters);
        Task<IEnumerable<FamilyDto>> UploadFiles(long creatorId, FamilyUploadDto filesDto);
        Task<byte[]> DownloadFamily(long familyId);
        Task<FamilyDto> AuditingFamily(long familyId,FamilyPutDto familyPutDto);
    }
}