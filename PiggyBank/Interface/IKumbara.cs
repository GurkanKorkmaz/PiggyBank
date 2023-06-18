using PiggyBank.Abstract;
using System.Collections.Generic;

namespace PiggyBank.Interface
{
    public interface IKumbara
    {
        void Shake(double minHacim);

        void ParaEkle(Para para);

        List<Para> Break();
    }
}
