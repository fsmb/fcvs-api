/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Code/description")]
    public class CodedDescription
    {
        [Description("Code")]
        public string Code { get; set; }

        [Description("Description of code")]
        public string Description { get; set; }
    }
}
