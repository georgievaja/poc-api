using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts.Types
{
    public interface INotFoundError
    {
        bool AreYouRobot { get; }
    }
}
