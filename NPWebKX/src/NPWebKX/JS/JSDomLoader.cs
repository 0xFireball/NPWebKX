using System.IO;
using System.Reflection;

namespace NPWebKX.JS
{
    public class JSDomLoader
    {
        public static Stream LoadUi8PScriptStream()
        {
            return typeof(JSDomLoader).GetTypeInfo().Assembly.GetManifestResourceStream("NPWebKX.JS.ui8p_pack.js");
        }

        public static Stream LoadJSDomScriptStream()
        {
            return typeof(JSDomLoader).GetTypeInfo().Assembly.GetManifestResourceStream("NPWebKX.JS.jsdom_nkx.min.js");
        }

        public static string LoadJSDomScriptDeps()
        {
            string result = string.Empty;

            using (var sr = new StreamReader(LoadUi8PScriptStream()))
            {
                result += sr.ReadToEnd();
            }
            return result;
        }

        public static string LoadJSDomScriptSource()
        {
            string result = string.Empty;
            using (var sr = new StreamReader(LoadJSDomScriptStream()))
            {
                result += sr.ReadToEnd();
            }
            return result;
        }
    }
}