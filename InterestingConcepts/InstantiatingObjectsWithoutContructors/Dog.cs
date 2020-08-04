namespace InterestingConcepts.InstantiatingObjectsWithoutContructors
{
    public class Dog
    {
        private Dog()
        {

        }

        public static Dog CreateDog()
        {
            return new Dog();
        }

        public string Bark() => "woof";
    }
}
