using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4ChanDownloader
{
    class Helper
    {
        public static WebProxy getProxy()
        {
            WebProxy proxy = new WebProxy(Properties.Settings.Default.ProxyServer);

            if (Properties.Settings.Default.ProxyUseCredentials)
            {
                proxy.Credentials = new NetworkCredential(Properties.Settings.Default.ProxyUsername, Properties.Settings.Default.ProxyPassword);
            }
            
            proxy.UseDefaultCredentials = false;
            proxy.BypassProxyOnLocal = false;

            return proxy;
        }
    }
}
