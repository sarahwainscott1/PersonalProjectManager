using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PersonalProjectManager.Models {
    public class Supplies {
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public int? ProjectId { get; set; }
        public virtual Project? Project { get; set; }

    }
}
