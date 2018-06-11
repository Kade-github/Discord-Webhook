using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Webhook
{
    public class webhook : IDisposable
    {
        private readonly WebClient c;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }

        public webhook()
        {
            c = new WebClient();
        }


        public void SendMessage(string msgSend)
        {
            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);
            c.UploadValues(WebHook, discordValues);
        }

        public void Dispose()
        {
            c.Dispose();
        }
    }
}