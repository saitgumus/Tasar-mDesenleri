using System;

namespace Composite
{
    class MainClass
    {
        /// <summary>
        /// composite => nesneler arası hiyerarşi akla gelmelidir.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            UIComponent component = new Form("test form");
            component.Add(new Input());
            component.Add(new Label("label1"));

            var subComp = new Form("sub component");
            subComp.Add(new Label("1 sub label"));
            subComp.Add(new Label("2 sub label"));
            subComp.Add(new Input());
            component.Add(subComp);

            Console.WriteLine(component.ToString());

            Console.ReadKey();
        }
    }
}
