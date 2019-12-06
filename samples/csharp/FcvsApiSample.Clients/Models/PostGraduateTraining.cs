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
    [Description("Postgraduate training")]
    public class PostGraduateTraining
    {
        //Ensure empty values are returned instead of null
        [Description("Accredited postgraduate training")]
        public IEnumerable<AccreditedTraining> AccreditedTraining { get; set; } = Enumerable.Empty<AccreditedTraining>();

        //Ensure empty values are returned instead of null
        [Description("Non-accredited postgraduate training")]
        public IEnumerable<OtherTraining> OtherTraining { get; set; } = Enumerable.Empty<OtherTraining>();
    }
}
