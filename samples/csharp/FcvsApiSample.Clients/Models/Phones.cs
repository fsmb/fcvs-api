/*
 * Copyright © 2018 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Phone information")]
    public class Phones
    {
        //Ensure arrays return empty if not set
        [Description("Other phone numbers")]
        public IEnumerable<Phone> Other { get; set; } = Enumerable.Empty<Phone>();
    }
}
