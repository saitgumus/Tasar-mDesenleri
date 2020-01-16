namespace Visitor
{
    public abstract class Tax
    {
        protected int quantity;
        
        protected Tax(int quantity)
        {
            this.quantity = quantity;
        }

        public abstract void Accept(Visitor visitor);
    }
}