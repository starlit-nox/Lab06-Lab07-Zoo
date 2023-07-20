using Zoo;

class Program
{
    static void Main()
    {
        Wolf wolf = new Wolf
        {
            FurColor = "Gray"
        };
        wolf.Sleep();
        wolf.Eat();
        wolf.Move();
        wolf.Walk();

        Leopard leopard = new Leopard
        {
            FurColor = "Spotted"
        };
        leopard.Sleep();
        leopard.Eat();
        leopard.Move();
        leopard.Walk();
    }
}
