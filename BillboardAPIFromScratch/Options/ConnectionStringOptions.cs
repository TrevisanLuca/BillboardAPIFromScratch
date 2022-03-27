using System.ComponentModel.DataAnnotations;
namespace BillboardAPIFromScratch.Options
{
    public class ConnectionStringOptions
    {
        [Required]
        public string DefaultDatabase { get; set; } = null!;
    }
}