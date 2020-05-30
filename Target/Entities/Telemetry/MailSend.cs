﻿using System;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.Telemetry
{
    public partial class MailSend : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime SendOn { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string Subject { get; set; }
    }
}
