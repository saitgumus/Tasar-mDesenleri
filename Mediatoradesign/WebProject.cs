using System;
using System.IO;
using System.Linq;

namespace Mediatoradesign
{
    public class WebProject : Project
    {

        public WebProject(string name) : base(name)
        {
        }

        public override void checkIn(Developer developer, string code)
        {
            StreamWriter streamWriter = new StreamWriter("./" + projectName + ".txt");
            streamWriter.Write(code);
            streamWriter.Close();
            changeSetId++;
            sendMessageToDev(developer, "new check-in done.  changeSetId:" + changeSetId.ToString());
        }


        public override void sendBroadcast(string message)
        {
            developers.ForEach(x => x.Notify(message));
        }

        public override void sendMessageToDev(Developer developer, string message)
        {
            developers.FirstOrDefault(x => x == developer).Notify(message);
        }
    }
}


    
        

        
