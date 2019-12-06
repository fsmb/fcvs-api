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
    [Description("Name(s) of a person")]
    public class Names
    {
        [Description("Legal name")]
        [Required]
        public Name LegalName { get; set; }

        //Ensure arrays return empty if not set
        [Description("Other names")]
        public IEnumerable<Name> Other { get; set; } = Enumerable.Empty<Name>();
    }
}
