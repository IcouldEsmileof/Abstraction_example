namespace Abstraction_example
{
    public abstract class Animal : ISpecies
    {
        private readonly string _species;

        protected Animal(string species)
        {
            _species = species;
        }

        public abstract string Speak();

        public string GetSpecies()
        {
            return _species;
        }
    }
}