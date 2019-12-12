using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RuneScape_Tool.Functions
{
    class DownloadHiscores
    {
        public string Download(string url, string username)
        {
            // Since we are accessing a HTTPS:// Page we need to change the Service Point Security Protocol to
            // Tls12 in order for it to actually work, otherwise it results in a fatal error.
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string HiscoresInformation = "";

            try
            {
                string FullUrl = "https://" + url + username;
                using (WebClient client = new WebClient())
                {
                    HiscoresInformation = client.DownloadString(FullUrl);
                    
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                throw e;           
            }

            return HiscoresInformation;
        }
    }
}
