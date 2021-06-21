using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonComparison
{
    public class DAO
    {
        public List<string> GetStates()
        {
            List<string> states = new List<string>();

            var sts = File.ReadAllLines(@"C:\Hands-On\SingletonComparison\SingletonComparison\Data\States.txt");
            foreach (var item in sts)
            {
                states.Add(item);
            }

            return states;
        }
    }
}
