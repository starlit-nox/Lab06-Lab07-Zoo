namespace Zoo
{
    class Wolf : Mammal, IWalk
    {
        public int Legs { get; set; }

        void IWalk.Walk()
        {
            Console.WriteLine("Zooom!");
        }
    }

    abstract class Mammal : Animal
    {
        public string FurColor { get; set; }
    }

    interface IWalk
    {
        void Walk();
    }
}
