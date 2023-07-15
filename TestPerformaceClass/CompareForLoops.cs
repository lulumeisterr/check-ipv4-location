
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace tipsPerformace.Loops.BenchMarker 
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    public class CompareForLoops 
    {
        List<string> names = new List<string>();

        public CompareForLoops() {
           names = getNames();
        }

        [Benchmark()]
        public void CompareForLoop() 
        {
            for (int i = 0; i < names.Count; i++)
            {
                var name = names[i];
            }
        }

        [Benchmark()]
        public void CompareForEach() 
        {
            foreach (var item in names)
            {
                var name = item;
            }
        }

        public List<string> getNames () 
        {
            TextReader reader = File.OpenText(@"Files/ibge-fem-10000.csv");
            // Lê cada linha do arquivo
            string line;
            int indiceLine = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if(indiceLine == 0) {
                    indiceLine++;
                    continue;
                }
                // Separa a linha em colunas
                string[] columns = line.Split(",");
                // Adiciona o nome à lista
                names.Add(columns[0]);
            }
            return names;
        }
    }
}