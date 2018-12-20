using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMP.Models
{
    public class Meeting
    {
        // Pulled from Team Project requirments

        // Meeting ID
        public int ID { get; set; }

        // Date of meeting
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // Conducting
        [Required]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        public string Conducting { get; set; }

        // Hymns
        [Required]
        [Range(1, 341)]
        [Display(Name = "Opening Hymn")]
        public int OpeningHymn { get; set; }

        [Required]
        [Range(169, 197)] // Range of current sac hymns
        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymn { get; set; }

        // Rest Hymn NOT required.
        [Range(1,341)]
        [Display(Name = "Rest Hymn")]
        public int RestHymn { get; set; }

        [Required]
        [Range(1, 341)]
        [Display(Name = "Closing Hymn")]
        public int ClosingHymn { get; set; }

        // Speakers NOT required
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Youth Speaker")]
        public string Speaker1 { get; set; }

        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Adult Speaker")]
        public string Speaker2 { get; set; }

        // 3rd speaker NOT required
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Display(Name = "Adult Speaker")]
        public string Speaker3 { get; set; }

        // Topic
        [Required]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        public string Topic { get; set; }

    }
}
