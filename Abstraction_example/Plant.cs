namespace Abstraction_example
{
    public class Plant:ISpecies
    {
        private string _species;

        protected Plant(string species)
        {
            _species = species;
        }

        public string GetSpecies()
        {
            return _species;
        }
    }
}