using System.Net;

namespace GOT.DataAccess
{
    public class RequestDataFromAPI
    {
        private string _baseURL = @"https://api.got.show/";

        public string RequestAllCharacters()
        {
            string getURL = _baseURL + @"/api/book/characters";

            return Request(getURL);
        }

        public string RequestCharacter(string caracterName)
        {
            var getURL = _baseURL + $"/api/book/characters/:{caracterName}";

            return Request(getURL);
        }

        private static string Request(string getURL)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;

            using (var client = new WebClient())
            {
                try
                {
                    var result = client.DownloadString(getURL);
                    return client.DownloadString(getURL);
                }
                catch (WebException exception)
                {
                    return "";
                }
            }
        }
    }
}
