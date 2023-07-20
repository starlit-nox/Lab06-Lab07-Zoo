namespace Zoo
{
    abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Zzzzzz...");
        }
        public virtual void Eat()
        {
            Console.WriteLine("is eating food.");
        }
        public virtual void Move()
        {
            Console.WriteLine("is moving around.");
        }
    }
}