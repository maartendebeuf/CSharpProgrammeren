﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3_3
{
    public class LockDoorWhileOpenException : Exception
    {
        public LockDoorWhileOpenException(string? message) : base(message)
        {

        }
    }
}
