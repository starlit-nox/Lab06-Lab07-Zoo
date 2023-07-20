namespace Zoo
{
    abstract class Mammal : Animal
    {
        public string FurColor { get; }

        protected Mammal(string furColor)
        {
            FurColor = furColor;
        }
    }
}
