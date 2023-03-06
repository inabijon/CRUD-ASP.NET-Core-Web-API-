using System.ComponentModel.DataAnnotations;

namespace CRUD__ASP.NET_Core_Web_API_
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;


    }
}
