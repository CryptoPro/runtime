// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.IO.Pipelines
{
    [Flags]
    internal enum ResultFlags : byte
    {
        None = 0x0,
        Canceled = 0x1,
        Completed = 0x2
    }
}
