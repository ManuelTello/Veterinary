using Veterinary.Backend.Domain.ObjectValues;

namespace Veterinary.Backend.Domain.AggregateRoots.Owner
{
    public sealed class Owner(Guid id, DateTime dateAddedToTheSystem, Email email)
    {
        public Guid Id { get; private set; } = id;

        public DateTime DateAddedToTheSystem { get; private set; } = dateAddedToTheSystem;

        public Email Email { get; private set; } = email;
    }
}

