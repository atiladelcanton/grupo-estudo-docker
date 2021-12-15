using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace apiorder.Models
{
    public class Customer
    {
        [Key]
        public int id {get;set;}
        public string? name {get;set;}
        public string? city {get;set;}
        public string? street {get;set;}
        public string? District {get;set;}

    }
}