namespace MiniStore.Domain.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
