using System;
namespace Mediatoradesign
{
    public abstract class Developer
    {
        public string userName;

        protected Developer(string userName)
        {
            this.userName = userName;
        }

        public abstract void Notify(string message);
    }
}
