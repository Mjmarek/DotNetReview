using System;

namespace _06_Polymorphism_Demo_3.Contracts
{
    public interface ISwipeable
    {
        void Accept();
        void Decline();
        void Swipe();
    }
}