using System.Runtime.Serialization;

namespace Shop.Web.Models
{
    [DataContract]
    public class Publisher
    {
        public int PublisherId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}