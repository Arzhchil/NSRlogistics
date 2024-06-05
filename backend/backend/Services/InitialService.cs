using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class InitialService : IInitial
    {
        public InitialService()
        {
        }

        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public int Hello()
        {
            return new Initial().MyProperty;
        }
    }
}
