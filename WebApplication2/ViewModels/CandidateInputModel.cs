using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Model;

namespace WebApplication2.ViewModels
{
    public class CandidateInputModel
    {
        [Key]
        public int CandidateId { get; set; }
        [Required, StringLength(50)]
        public string CandidateName { get; set; } = default!;
        [Required, DataType(DataType.Date)]
        public System.DateTime BirthDate { get; set; }
        [Required, StringLength(30)]
        public string AppliedFor { get; set; } = default!;
        [Required, Column(TypeName = "money"), DataType(DataType.Currency)]
        public decimal ExpectedSalary { get; set; }
        public bool WorkFromHome { get; set; }
        [Required, StringLength(30)]
        public string Picture { get; set; } = default!;
        public virtual List<Qualification>? Qualifications { get; set; } = new List<Qualification>();
    }
}
