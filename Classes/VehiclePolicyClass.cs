namespace FactoryDemo.Classes
{
    internal class VehiclePolicyClass : PolicyAbstractClass
    {
        //variables
        private string model;
        private string color;
        private int year;

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// A constructor method that initializes these variables.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="year"></param>
        public VehiclePolicyClass(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// this method overrides the corresponding method in the base class to generate a 
        /// string representing the vehicle insurance policy, including the model, color, and year.
        /// </summary>
        /// <returns></returns>
        public override string GeneratePolicy()
        {
            return $"Vehicle Insurance Policy Created for {model} {color} {year}.";
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

