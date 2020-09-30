namespace LearningClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public static bool IsOnEarth =true;

        //Instance Constructor

        // Default constructor - parameter less
        public Country()
        {

        }

        // Parameterized contructor
        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }

        //static constructor
        static Country()
        {

        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();   
            Country country2 = new Country("Nepal");                     
        }
    }
}