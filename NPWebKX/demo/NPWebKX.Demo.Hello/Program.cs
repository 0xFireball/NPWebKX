using NPWebKX.JS;
using NPWebKX.JSDom;

namespace NPWebKX.Demo.Hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jd = new JSDomApi();
            var document = jd.CreateDocument();
        }
    }
}