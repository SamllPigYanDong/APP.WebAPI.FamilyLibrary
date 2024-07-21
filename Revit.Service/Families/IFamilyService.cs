using Revit.Entity.Commons;
using Revit.Entity.Entity.Dtos.Family;
using Revit.Entity.Family;

namespace Revit.Service.Families
{
    public interface IFamilyService
    {
        Task<IEnumerable<FamilyDto>> GetFamiliesByUser(long userId);
        Task<PagedList<FamilyDto>> GetListAsync(PageRequestDto parameters);
        Task<IEnumerable<FamilyDto>> UploadFiles(FamilyUploadDto filesDto);
        Task<byte[]> DownloadFamily(long familyId);
        Task<FamilyDto> AuditingFamily(long familyId,FamilyPutDto familyPutDto);
    }
}