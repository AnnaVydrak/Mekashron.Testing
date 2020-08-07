using System.IO;
using System.Xml.Serialization;

namespace Mekashron.Testing.Web.Helpers
{
    public  static class SerializeObject
    {

        public static string SerializeObj<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static T DeserializeObj<T>(string content)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (TextReader textWriter = new StringReader(content))
            {
                return (T)xmlSerializer.Deserialize(textWriter);
            }
        }
    }
}