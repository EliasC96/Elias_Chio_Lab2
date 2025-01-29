namespace Elias_Chio_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }  //navigation property
        public int CategoryID { get; set; }
        public Category Category { get; set; }  //navigation property
    }
}
