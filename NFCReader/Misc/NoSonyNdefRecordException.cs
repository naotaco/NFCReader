﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdefUtils
{
    public class NoSonyNdefRecordException : Exception
    {
        public NoSonyNdefRecordException()
        {
        }

        public NoSonyNdefRecordException(String message)
            : base(message)
        {
        }
    }
}
