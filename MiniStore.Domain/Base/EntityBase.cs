namespace MiniStore.Domain.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public bool Status { get; protected set; }
        public DateTimeOffset DataCadastro { get; protected set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
            Status = true;
            DataCadastro= DateTimeOffset.Now;
        }
    }
}
