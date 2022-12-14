using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class tr_bpkb
    {
        [Key]
        public string agreement_number { get; set; }
        public string bpkb_no { get; set; }
        public string branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }

        // Foreign key 
        [Display(Name = "ms_storage_location")]
        public string location_id { get; set; }
        [ForeignKey("location_id")]
        public virtual ms_storage_location ms_storage_location { get; set; }
        public string police_no { get; set; }
        public DateTime bpkb_date_in { get; set; }
    }
}
