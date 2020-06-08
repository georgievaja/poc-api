using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts.Types
{
    public class NotFoundError : INotFoundError
    {
        public NotFoundError(string freud, bool areYouRobot)
        {
            Freud = freud;
            AreYouRobot = areYouRobot;
        }

        public bool AreYouRobot { get; }

        public string Freud { get; }
    }
}
