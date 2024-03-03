using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Helpers
{
    public static class CommonHelpers
    {
        public static string ToXml(this object o)
        {
            if (o == null)
            {
                return string.Empty;
            }
            try
            {
                var serializer = new XmlSerializer(o.GetType());

                using var memoryStream = new MemoryStream();
                using var streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8);

                serializer.Serialize(streamWriter, o);

                memoryStream.Seek(0, SeekOrigin.Begin);
                using var streamReader = new StreamReader(memoryStream, System.Text.Encoding.UTF8);
                return streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
