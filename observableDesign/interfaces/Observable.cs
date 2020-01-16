using System;

namespace observerDesign
{
    public interface Observable
    {
        void AddUser(Observer observer);
        void RemoveUser(Observer observer);
        void Notify(string message);
    }
}
