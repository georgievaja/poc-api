using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts.Types
{
    public class BadDataError : IBadDataError
    {
        public BadDataError(string freud, int jokesCount)
        {
            Freud = freud;
            JokesCount = jokesCount;
        }

        public int JokesCount { get; }

        public string Freud { get; }
    }
}
