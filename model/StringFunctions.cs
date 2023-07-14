using System.Text;
using BenchmarkDotNet.Attributes;

namespace tipsPerformace.BenchMarker {
    public class StringFunctions 
    {
        [Benchmark()]
        public void BuildStringBadly() 
        {
            string items = String.Empty;

            for (int i = 0; i < 50; i++)
            {
                items += " " + "TESTE";
            }
        }

        [Benchmark()]
        public void BuildStringBetter() 
        {
            StringBuilder items = new StringBuilder();
            for (int i = 0; i < 50; i++)
            {
                items.Append(' ');
                items.Append("TESTE");
            }
        }  
    }
}