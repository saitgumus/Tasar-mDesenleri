using System;
namespace observerDesign
{
    public interface Observer
    {
        void Notify(string message);
    }
}
