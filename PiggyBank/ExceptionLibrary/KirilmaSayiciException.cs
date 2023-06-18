using System;

namespace PiggyBank.ExceptionLibrary
{
    public class KirilmaSayiciException : Exception
    {
        public KirilmaSayiciException() : base("Kırılma sayısını aştınız daha fazla kumbarayı kıramazsınız!")
        {

        }
    }
}
