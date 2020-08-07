using System.Threading.Tasks;
using Mekashron.Testing.Web.Helpers;

namespace Mekashron.Testing.Web.Abstract.Logic
{
    public interface ISOAPClient
    {
         Task<Result> Login(SOAPModel.Login.Envelope login);
         Task<Result> Register(SOAPModel.Register.Envelope register);
    }
}