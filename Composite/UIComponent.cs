using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    
    public abstract class UIComponent
    {

        public List<UIComponent> uiComponents = new List<UIComponent>();

        public abstract UIComponent Add(UIComponent uiComponent);

        public abstract UIComponent remove(UIComponent uiComponent);

    }


    /// <summary>
    /// Leaf component
    /// </summary>
    public class Label : UIComponent
    {
        public string text { get; set; }

        public Label(string txt)
        {
            this.text = txt;
        }
        public override UIComponent Add(UIComponent uiComponent)
        {
            throw new NotImplementedException();
        }

        public override UIComponent remove(UIComponent uiComponent)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"<Label> {this.text} <Label/>";
        }
    }


    /// <summary>
    /// Leaf comp.
    /// </summary>
    public class Input : UIComponent
    {
        public override UIComponent Add(UIComponent uiComponent)
        {
            throw new NotImplementedException();
        }

        public override UIComponent remove(UIComponent uiComponent)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "<Input />";
        }
    }


    /// <summary>
    /// component
    /// </summary>
    public class Form : UIComponent
    {

        public string Name { get; set; }

        public Form(string name)
        {
            this.Name = name;
        }

        public override UIComponent Add(UIComponent uiComponent)
        {
            uiComponents.Add(uiComponent);
            return uiComponent;
        }

        public override UIComponent remove(UIComponent uiComponent)
        {
            uiComponents.Remove(uiComponent);

            return uiComponent;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder($"<form name='{Name}'>")
                .Append("\n");

            uiComponents.ForEach(x => builder.AppendLine(x.ToString()));

            return builder.ToString();
        }
    }
}
