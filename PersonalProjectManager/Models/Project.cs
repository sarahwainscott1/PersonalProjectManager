using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalProjectManager.Models {
    public class Project {

        public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; } =string.Empty;
        [StringLength(20)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(9,2)")]
        public float EstimatedHours { get; set; } = 0;
        [Column(TypeName = "decimal(9,2)")]
        public float HoursWorks { get; set; } = 0;
        [Column(TypeName = "decimal(9,2)")]
        public float HoursLeft { get; set; } = 0;
        public virtual List<Supplies>? Supplies { get; set; }
    }
}
