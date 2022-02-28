
using System.ComponentModel.DataAnnotations;

namespace client.Models
{
    public class Client
    {
        [Key]
        public int id {get;set;}
        public string? name {get;set;}
        public string? city {get;set;}
        public string? street {get;set;}
        public string? District {get;set;}
    }
}