/*
 * Copyright © 2018 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Email information")]
    public class EmailAddresses
    {
        [Required]
        [Description("Primary email")]
        public EmailAddress Primary { get; set; }

        //Ensure arrays return empty if not set
        [Description("Other emails")]
        public IEnumerable<EmailAddress> Other { get; set; } = Enumerable.Empty<EmailAddress>();
    }
}
