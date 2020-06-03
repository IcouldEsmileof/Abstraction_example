namespace Abstraction_example
{
    public class Dog : Animal
    {
        public Dog() : base("Dog")
        {
        }

        public override string Speak()
        {
            return "Woof";
        }
    }
}