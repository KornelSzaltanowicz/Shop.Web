using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Shop.Web.Models
{
    [DataContract]
    public class Book
    {
        public int BookId { get; set; }
        [DataMember]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [DataMember]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime PublicDate { get; set; }
        [DataMember]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataMember]
        [Display(Name = "Autor")]
        public virtual Author Author { get; set; }
        [DataMember]
        [Display(Name = "Wydawnictwo")]
        public virtual Publisher Publisher { get; set; }
        [DataMember]
        public virtual BookType Type { get; set; }
        [DataMember]
        // 1 - super okazja 
        public int Opportunity { get; set; }
        
    }
}