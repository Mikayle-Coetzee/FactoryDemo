namespace FactoryDemo.Classes
{
    abstract class PolicyFactoryAbstractClass
    {
        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// This method has no parameters and returns an object of type PolicyAbstractClass.
        /// </summary>
        /// <returns></returns>
        public abstract PolicyAbstractClass CreatePolicy();

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// This method takes an array of parameters of type object and returns an object of type PolicyAbstractClass.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public abstract PolicyAbstractClass CreatePolicy(params object[] parameters);

    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
