using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ComparePerfromance>();
            Console.ReadLine();
        }
    }

    [KeepBenchmarkFiles]
    [RPlotExporter]
    [HtmlExporter]
    [NativeMemoryProfiler]
    [MemoryDiagnoser]
    public class ComparePerfromance
    {
        [Benchmark]
        public void CallNormal()
        {
           
            for (int i = 0; i < 5; i++)
            {
                DAO ObjDAO = new DAO();
                int iCount = ObjDAO.GetStates().Count;
            }
        }

        [Benchmark]
        public void CallSingleton()
        {
            for (int i = 0; i < 5; i++)
            {
                int iCount = StateDataCache.Names.Count;
            }

        }

    }
}
