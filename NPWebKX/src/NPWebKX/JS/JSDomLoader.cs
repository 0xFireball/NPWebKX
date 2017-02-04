using System.IO;
using System.Reflection;

namespace NPWebKX.JS
{
    public class JSDomLoader
    {
        public static Stream LoadJSDomScriptStream()
        {
            return typeof(JSDomLoader).GetTypeInfo().Assembly.GetManifestResourceStream("JS.jsdom_nkx.min.js");
        }

        public static string LoadJSDomScriptSource()
        {
            string result;
            using (var sr = new StreamReader(LoadJSDomScriptStream()))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}