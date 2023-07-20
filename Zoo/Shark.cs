namespace Zoo
{
    class Shark : Fish, ISwim
    {
        public int Fins { get; set; }

        public void Swim()
        {
            Console.WriteLine("Glub, glub!");
        }
    }
}
