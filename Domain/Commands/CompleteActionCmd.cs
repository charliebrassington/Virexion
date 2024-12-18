﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class CompleteActionCmd : BaseCommand
    {
        public required string ActionName { get; set; }
        public required List<string> Arguments { get; set; }
    }
}
