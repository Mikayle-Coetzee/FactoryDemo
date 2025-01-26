using System;

namespace FactoryDemo.Classes
{
    internal class VehiclePolicyFactoryClass : PolicyFactoryAbstractClass
    {
        /// <summary>
        /// This method returns null
        /// </summary>
        /// <returns></returns>
        public override PolicyAbstractClass CreatePolicy()
        {
            return null; 
        }

        /// <summary>
        /// This method creates a VehiclePolicyClass object if the parameters passed are valid
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override PolicyAbstractClass CreatePolicy(params object[] parameters)
        {
            if (parameters.Length == 3 && parameters[0] is string model && parameters[1] is string color && parameters[2] is int year)
            {
                return new VehiclePolicyClass(model, color, year);
            }
            else
            {
                throw new ArgumentException("Invalid parameters for creating VehiclePolicy.");
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
