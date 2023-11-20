namespace SuperPosition_Delegation
{
    public class Display
    {
        private int[] brightnessRange = new int[] { 0, 10 };
        private int brightnessLevel = 5;
        public double SizeInches { get; set; }
        public int HeightResolution { get; set; } = 1080;
        public int WidthResolution { get; set; } = 1920;
        public TypeOfCover TypeOfCover { get; set; }
        public int IncreaseBrigthness()
        {
            if (brightnessLevel < brightnessRange[1])
            {
                brightnessLevel++;
            }
            return brightnessLevel;
        }
        public int DecraseBrigthness()
        {
            if (brightnessLevel > brightnessRange[0])
            {
                brightnessLevel--;
            }
            return brightnessLevel;
        }
    }
    public enum TypeOfCover
    {
        Glossy, Matt
    }

    public class SmartPhone
    {
        private Display display;
        public SmartPhone(string model)
        {
            Model = model;
            display = new Display();
        }

        public SmartPhone(string model, Display display) : this(model)
        {
            display = display;
        }

        public string Model { get; set; }

        //Delegation
        public void MakeBrighter()
        {
            int currentBrightnessLevel = display.IncreaseBrigthness();
            Console.WriteLine($"Brightness was set to {currentBrightnessLevel}");


        }


    }


}
