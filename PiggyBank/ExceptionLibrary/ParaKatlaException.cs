using System;

namespace PiggyBank.ExceptionLibrary
{
    public class ParaKatlaException : Exception
    {
        public ParaKatlaException() : base("Para katlamadan kumbaraya atamazsınız!")
        {

        }
    }
}
