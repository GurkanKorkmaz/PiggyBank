using System;

namespace PiggyBank.ExceptionLibrary
{
    public class KumbaraDolduException : Exception
    {
        public KumbaraDolduException() : base("Kumbara doldu daha fazla para atamazsınız veya kumbarayı sallayın!")
        {

        }
    }
}
