﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3_3
{
    public class CloseDoorWhileClosedException : Exception
    {
        public CloseDoorWhileClosedException(string? message) : base(message)
        {

        }
    }
}
