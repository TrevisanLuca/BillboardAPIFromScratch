using System.ComponentModel.DataAnnotations;

namespace BillboardAPIFromScratch.Domain
{
    public record Author(
        int? Id = default,        
        string Name = "",        
        string Surname = "",
        string Mail = "",
        DateTime? CreatedAt = default,
        DateTime? Updatedat = default
        );
}