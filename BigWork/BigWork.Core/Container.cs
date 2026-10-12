namespace BigWork.Core
{
    public sealed class Container<T> : IContainer<T>
    {
        private readonly T item;
        public Container(T item)
        {
            this.item = item;
        }
        public T GetItem() => item;
    }
}
