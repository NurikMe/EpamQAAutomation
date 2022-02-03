namespace Task4.CarParts
{
    public abstract class AbstractPart
    {
        protected abstract string Specification();
        public override string ToString()
        {
            return Specification();
        }
    }
}
