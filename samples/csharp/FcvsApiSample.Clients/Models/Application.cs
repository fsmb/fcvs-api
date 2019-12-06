/*
 * Copyright © 2018 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    public class Application
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Name of the board")]
        public string BoardName { get; set; }

        [Description("Date the profile was sent (UTC)")]
        public DateTime? SentDateUtc { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Status of the profile (Submitted, Complete)")]
        public string Status { get; set; }

    }
}
