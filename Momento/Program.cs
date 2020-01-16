using System;
using System.Collections.Generic;
using System.Linq;

namespace Momento
{
    class MainClass
    {
        /// <summary>
        /// Bu desen, nesnelerin tamamının veya belirli bir kısmının, belirli bir anda kayıt altına alınarak daha sonra tekrar oluşturulabilmesini sağlar.
        /// İlk halini veya özel bir durumdaki halini elde etmek isteyebileceğimiz nesneler için kullanılır.
        /// nesneleri veri elemanlarındaki taşıdıkları verilere durum bilgisi(state) denilir
        /// nesne durumunu önceki haline getirebilmek için kullanılır
        /// Terminolojide durum bilgisi korunarak önceki duruma geri döndürülmek istenilen nesnelere *Originator* denir.
        /// Originator’un hangi alan ve özelliklerinin işleneceği bilgisi *Memento* isimli nesne ile dışsal şekilde saklanır.
        ///  *Caretaker* ismi ile sembolize edilmiş bir nesne içinde n tane Memento nesnesi saklanabilir.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            Project project = new Project();
            project.ProjectName = "test";
            project.Code = " printf('hello world!')";
            project.developer = "sgumus";

            Memento memento = project.CreateMemento();

            Console.WriteLine( project.ToString() );
            project.Commit(memento, "first commit");

            project.Code = " echo 'hello!!' ";
            project.developer = "gs";

            Console.WriteLine(project.ToString());
            project.Commit(memento, "sec commit");


            var lst = memento.GetChangeIdList();
            Console.WriteLine("changeset list:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            project.Undo(memento.GetMemento(1));

            Console.WriteLine(project.ToString());

        }
    }

    /// <summary>
    /// Orginator nesne
    /// </summary>
    class Project
    {
        public string ProjectName { get; set; }
        public string Code { get; set; }
        public string developer { get; set; }

        public Memento CreateMemento()
        {

            return new Memento();
        }

        public void Commit(Memento m,string message)
        {
           m.SetMemento(ProjectName, Code, developer, message);
        }

        public void Undo(Memento m)
        {
            ProjectName = m.ProjectName;
            Code = m.Code;
            developer = m.developer;
        }

      
        public override string ToString()
        {
            return string.Format("project:{0} \n code:{1} \n dev:{2}", ProjectName, Code, developer);
        }

    }


    /// <summary>
    /// memento
    /// </summary>
    class Memento
    {
        CareTaker CareTaker = new CareTaker();
        public int changeSetId;
        public string Message { get; set; }
        public string  ProjectName { get; set; }
        public string Code { get; set; }
        public string developer { get; set; }

        public Memento()
        {
            
        }

        public void SetMemento(string pname, string code, string dev, string message)
        {
            var m = new Memento();
            m.ProjectName = pname;
            m.Code = code;
            m.developer = dev;
            m.Message = message;
            m.changeSetId = this.changeSetId += 1;
            CareTaker.memList.Add(m);
        }

        public Memento GetMemento(int cs)
        {
            return CareTaker.memList.Find(x => x.changeSetId == cs);
        }

        public string[] GetChangeIdList()
        {
            var lst = new String[CareTaker.memList.Count];

            int x = 0;
            foreach (var item in CareTaker.memList)
            {
                lst[x++] = item.changeSetId.ToString();
            }
            return lst;
        }
    }

    /// <summary>
    /// Care Taker
    /// </summary>
    class CareTaker
    {
        public List<Memento> memList = new List<Memento>();

        public CareTaker()
        {
        }

        
    }


}
