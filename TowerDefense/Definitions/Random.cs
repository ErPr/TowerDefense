namespace TreehouseDefense.Definitions
{
    static class Random
    {
        // static classes need static members

        // Need to specify that we want to use System.Random
        private static System.Random _random = new System.Random();

        public static double NextDouble()
        {
            return _random.NextDouble(); 
        }
    }
}