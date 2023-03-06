using System.ComponentModel.DataAnnotations;

namespace CRUD__ASP.NET_Core_Web_API_
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string StatusOption { get; set; } = string.Empty;
    }
}
