using System;

namespace FactoryDemo.Classes
{
    internal class HouseholdPolicyFactoryClass : PolicyFactoryAbstractClass
    {
        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// This method returns null
        /// </summary>
        /// <returns></returns>
        public override PolicyAbstractClass CreatePolicy()
        {
            return null; 
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// This method creates a HouseholdPolicyClass object if the parameters passed are valid (a single 
        /// decimal value indicating contents value)
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override PolicyAbstractClass CreatePolicy(params object[] parameters)
        {
            if (parameters.Length == 1 && parameters[0] is decimal contentsValue)
            {
                return new HouseholdPolicyClass(contentsValue);
            }
            else
            {
                throw new ArgumentException("Invalid parameters for creating HouseholdPolicy.");
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
