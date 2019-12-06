using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Practitioner profile for a board")]
    public class Profile
    {
        [Description("Unique ID")]
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("FID of practitioner")]
        public string Fid { get; set; }

        [Description("Date the profile was submitted (UTC)")]
        public DateTime SubmitDateUtc { get; set; }

        [Required]
        [Description("Application information")]
        public Application Application { get; set; } = new Application();

        [Required]
        [Description("Identity")]
        public Identification Identity { get; set; } = new Identification();

        [Required]
        [Description("Names")]
        public Names Names { get; set; } = new Names();

        //Contacts
        [Required]
        [Description("Mailing addresses")]
        public Addresses Addresses { get; set; } = new Addresses();

        [Required]
        [Description("Email addresses")]
        public EmailAddresses EmailAddresses { get; set; } = new EmailAddresses();

        [Required]
        [Description("Phone numbers")]
        public Phones Phones { get; set; } = new Phones();

        [Required]
        [Description("Medical education")]
        public MedicalEducationTraining MedicalEducation { get; set; } = new MedicalEducationTraining();

        [Description("Postgraduate training")]
        public PostGraduateTraining PostGraduateTraining { get; set; }

        [Description("Exams")]
        public IEnumerable<Exam> Exams { get; set; } = Enumerable.Empty<Exam>();

        [Description("Licensure")]
        public IEnumerable<License> Licenses { get; set; } = Enumerable.Empty<License>();

        //Ensure arrays return empty if not set
        [Description("Chronology of activity")]
        public IEnumerable<Activity> Activities { get; set; } = Enumerable.Empty<Activity>();
    }
}
