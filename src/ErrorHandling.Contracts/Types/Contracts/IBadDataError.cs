﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts.Types
{
    public interface IBadDataError : IError
    {
        int JokesCount { get; }
    }
}
