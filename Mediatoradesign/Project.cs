using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mediatoradesign
{
    public abstract class Project
    {
        protected List<Developer> developers;
        protected int changeSetId;
        protected string projectName;

        protected Project(string name)
        {
            developers = new List<Developer>();
            changeSetId = 0;
            projectName = name;
        }


        public void AddDeveloper(Developer developer)
        {
            if(!developers.Contains(developer))
            {
                developers.Add(developer);
            }
        }

        public void RemoveDeveloper(Developer developer)
        {
            if (developers.Contains(developer))
            {
                developers.Remove(developer);
            }
        }

        public abstract void sendMessageToDev(Developer developer, string message);

        public abstract void sendBroadcast(string message);
    
        public abstract void checkIn(Developer developer, string code);

        
    }
}
