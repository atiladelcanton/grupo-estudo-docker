
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
        public string? district {get;set;}
        public string? cpf {get;set;}
        public string? cep {get;set;}
        public string? telephone {get;set;}
        public DateTime createdAt {get;set;}
        public DateTime updatedAt {get;set;}
    }
}