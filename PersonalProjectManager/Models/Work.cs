using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalProjectManager.Models {
    public class Work {
        public int Id { get; set; }
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(9,2)")]
        public int Hours { get; set; } = 0;
        public int? ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
