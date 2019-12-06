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
    [Description("Mailing addresses")]
    public class Addresses
    {
        //Ensure arrays return empty if not set
        [Description("Addresses")]
        public IEnumerable<Address> Other { get; set; } = Enumerable.Empty<Address>();
    }
}
