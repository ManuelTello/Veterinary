using Veterinary.Backend.Domain.ObjectValues;

namespace Veterinary.Backend.Domain.AggregateRoots.Owner
{
    public sealed class Owner
    {
        public Guid Id { get; private set; }

        public DateTime DateAddedToTheSystem { get; private set; }

        public Email Email { get; private set; }

        public Name Name { get; private set; }

        public Owner(Guid id, DateTime dateAddedToTheSystem, Email email, Name name)
        {
            this.Id = id;
            this.DateAddedToTheSystem = dateAddedToTheSystem;
            this.Email = email;
            this.Name = name;
        }

        private Owner() { }
    }
}

