using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace apiorder.Models
{
    public class Item
    {
        [Key]
        public int id {get;set;}

        public string? description {get;set;}

        public decimal quantity {get;set;}

        public decimal valueTotal {get;set;}

        [ForeignKeyAttribute("Order")]
        public int orderid {get;set;}

    }
}