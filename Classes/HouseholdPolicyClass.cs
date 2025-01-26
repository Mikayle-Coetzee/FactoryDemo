namespace FactoryDemo.Classes
{
    internal class HouseholdPolicyClass : PolicyAbstractClass
    {
        private decimal contentsValue;

        /// <summary>
        /// this constructor initializes the contentsValue field.
        /// </summary>
        /// <param name="contentsValue"></param>
        public HouseholdPolicyClass(decimal contentsValue)
        {
            this.contentsValue = contentsValue;
        }

        /// <summary>
        /// this method inherited from the base class. This method generates a string representation of the 
        /// household insurance policy, including the contents value formatted as currency.
        /// </summary>
        /// <returns></returns>
        public override string GeneratePolicy()
        {
            return $"Household Contents Insurance Policy Created with contents value {contentsValue:C}.";
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//