using System.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using Mekashron.Testing.Web.Helpers;

namespace Mekashron.Testing.Web.Logic
{
    public class BaseSOAPClient
    {
        private HttpWebRequest CreateSOAPWebRequest()
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["IICUTechUrl"]);
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            Req.Method = "POST";

            return Req;
        }

        public async Task<string> BaseRequest(object contentObject)
        {
            HttpWebRequest request = CreateSOAPWebRequest();
            XmlDocument body = new XmlDocument();
            string content = contentObject.SerializeObj();
            body.LoadXml(content);

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                body.Save(stream);
            }

            using (WebResponse serviceres = await request.GetResponseAsync())
            {
                using (StreamReader rd = new StreamReader(serviceres.GetResponseStream()))
                {
                    return await rd.ReadToEndAsync();
                }
            }
        }
    }
}