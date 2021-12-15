using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace apiorder.Models
{
    public class Order
    {
        [Key]
        public int id {get;set;}

        public decimal total {get;set;}

        public DateTime date {get;set;}

        [ForeignKeyAttribute("Customer")]
        public int customerid {get;set;}

        public virtual Customer customer {get;set;}

        public virtual List<Item> itens {get;set;}
    }
}