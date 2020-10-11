using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAspNetCoreApp.Services
{
    public interface IStringManipulation
    {
        string MakeFirstLetterUpper(string input);
    }
}
