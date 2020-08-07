using System.Threading.Tasks;
using Mekashron.Testing.Web.Abstract.Logic;
using Mekashron.Testing.Web.Helpers;
using Mekashron.Testing.Web.SOAPModel;
using Newtonsoft.Json.Linq;

namespace Mekashron.Testing.Web.Logic
{
    public class SOAPClient : BaseSOAPClient, ISOAPClient
    {
        public async Task<Result> Login(SOAPModel.Login.Envelope login)
        {
            var response = await BaseRequest(login);

            Envelope envelope = SerializeObject.DeserializeObj<Envelope>(response);


            if (envelope?.Body?.LoginResponse?.@return != null)
            {
                if (!envelope.Body.LoginResponse.@return.Contains("ResultCode"))
                {
                    return Result.Ok();
                }

                var obj = JObject.Parse(envelope?.Body?.LoginResponse?.@return);

                int result = int.Parse((obj["ResultCode"].ToString()));

                if (result == 1)
                {
                    return  Result.Ok();
                }
                else
                {
                    return Result.Fail(obj["ResultMessage"].ToString());
                }
            }

            return Result.Fail("sorry, some error! Please, again later");
        }
        public async Task<Result> Register(SOAPModel.Register.Envelope register)
        {
            var response = await BaseRequest(register);

            Envelope envelope = SerializeObject.DeserializeObj<Envelope>(response);


            if (envelope?.Body?.RegisterNewCustomerResponse?.@return != null)
            {
                var obj = JObject.Parse(envelope?.Body?.RegisterNewCustomerResponse?.@return);

                int result = int.Parse((obj["ResultCode"].ToString()));

                if (result == 1)
                {
                    return  Result.Ok();
                }
                else
                {
                    return Result.Fail(obj["ResultMessage"].ToString());
                }
            }

            return Result.Fail("sorry, some error! Please, again later");
        }
    }
}