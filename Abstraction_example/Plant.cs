namespace Abstraction_example
{
    public abstract class Plant:ISpecies
    {
        private readonly string _species;

        protected Plant(string species)
        {
            _species = species;
        }

        public abstract string GetColorOfFlower();
        
        public string GetSpecies()
        {
            return _species;
        }
    }
}