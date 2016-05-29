namespace Shop.Web.Models
{
    //Nosnik
    public class DataCarrier
    {
        public int DataCarrierId{ get; set; }
        public DataCarrierType Type{ get; set; }
    }

    public enum DataCarrierType { CD, PDF, EPUB, MOBI }
}