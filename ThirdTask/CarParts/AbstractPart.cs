namespace ThirdTask.CarParts
{
    public abstract class AbstractPart
    {
        protected abstract string Specification();

        public override string ToString() => Specification();
    }
}
