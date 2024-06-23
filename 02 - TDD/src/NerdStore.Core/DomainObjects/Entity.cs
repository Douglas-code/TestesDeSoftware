using NerdStore.Core.Messages;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        private List<Event> _eventos;
        public IReadOnlyCollection<Event> Eventos => _eventos?.AsReadOnly();

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public void AdicionarEvento(Event evento)
        {
            _eventos = _eventos ?? new List<Event>();
            _eventos.Add(evento);
        }

        public void RemoverEvento(Event eventItem)
        {
            _eventos?.Remove(eventItem);
        }

        public void LimparEventos()
        {
            _eventos?.Clear();
        }
    }
}