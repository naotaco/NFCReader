﻿using System;

namespace NdefUtils
{
    public class NoNdefRecordException : Exception
    {

        public NoNdefRecordException()
        {
        }

        public NoNdefRecordException(String message)
            : base(message)
        {
        }


    }
}
