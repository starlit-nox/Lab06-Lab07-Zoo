using Zoo;

namespace Zoo;
{
    class Leopard : Cage.Mammal, IWalk
{
    public void Walk()
    {
        Console.WriteLine("Nyooom!");
    }
}

interface IWalk
{
    void Walk();
}
}

namespace Cage
{
    abstract class Mammal : Animal
    {
        public required string FurColor;
    }
}
