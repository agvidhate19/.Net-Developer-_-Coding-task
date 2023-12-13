using System.ComponentModel.DataAnnotations;

namespace ReactAPICoreCurd.Model
{
    public class customerDetails
    {
        [Key]
        public int CID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string CountryCode { get; set; }
        public string Gender { get; set; }
        public double Balance { get; set; }
    }
}
