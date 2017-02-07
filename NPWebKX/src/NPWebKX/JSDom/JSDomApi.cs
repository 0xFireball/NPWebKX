using System;
using IridiumJS;
using NPWebKX.JS;

namespace NPWebKX.JSDom
{
    public class JSDomApi
    {
        private JSEngine _jsEngine = new JSEngine();

        public JSDomApi()
        {
            _jsEngine.SetValue("setGlobal", new Action<string, object>(SetGlobal));
            _jsEngine.Execute(JSDomLoader.LoadJSDomScriptDeps());
            var xx = _jsEngine.GetValue("Uint8Array");
            _jsEngine.Execute(JSDomLoader.LoadJSDomScriptSource());
        }

        public void SetGlobal(string n, object x)
        {
            _jsEngine.SetValue(n, x);
        }

        public dynamic CreateDocument()
        {
            return _jsEngine.Execute("new jsdom()").GetCompletionValue();
        }
    }
}