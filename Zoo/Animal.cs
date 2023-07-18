namespace Zoo
{
    abstract class Animal : AnimalBase
    {
        public override void Sleep()
        {
            Console.WriteLine("Zzzzzz...");
        }
        public override void Eat()
        {
            Console.WriteLine("is eating food.");
        }
        public override void Move()
        {
            Console.WriteLine("is moving around.");
        }
    }