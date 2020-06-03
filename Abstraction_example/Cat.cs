namespace Abstraction_example
{
    public class Cat : Animal
    {
        public Cat( ) : base("Cat")
        {
        }

        public override string Speak()
        {
            return "Mew";
        }
    }
}