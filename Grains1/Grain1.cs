using System.Threading.Tasks;
using Orleans;

namespace Grains1
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class Grain1 : Grain, GrainInterfaces1.IGrain1
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World!");
        }
    }
}