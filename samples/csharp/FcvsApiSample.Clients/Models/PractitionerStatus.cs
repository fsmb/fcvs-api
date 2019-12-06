using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    /// <summary>Provides the status of a practitioner.</summary>
    [Description("Represents the status of a practitioner.")]
    public class PractitionerStatus
    {
        /// <summary>The FID of the practitioner.</summary>
        [Required(AllowEmptyStrings = false)]
        [Description("The FID.")]
        public string Fid { get; set; }

        /// <summary>The name of the practitioner.</summary>
        [Required]
        [Description("The name.")]
        public Name Name { get; set; }

        /// <summary>Gets or sets the ID of the practitioner.</summary>
        [Description("The ID of the last profile.")]
        public long LastProfileId { get; set; }

        /// <summary>Gets or sets the status of the last profile.</summary>
        [Description("The status of the last profile.")]
        public string LastProfileStatus { get; set; }

        /// <summary>Gets or sets the last submit date, in UTC.</summary>
        [Description("The date/time the last profile was submitted, in UTC.")]
        public DateTime LastProfileSubmitDateUtc { get; set; }

        /// <summary>Gets or sets the last sent date, in UTC.</summary>
        [Description("The date/time the last profile was sent, in UTC.")]
        public DateTime? LastProfileSentDateUtc { get; set; }
    }
}
