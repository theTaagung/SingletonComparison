using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonComparison
{
    public sealed class StateDataCache

    {
        private static Lazy<StateDataCache> local = new Lazy<StateDataCache>(GetData);

        private List<string> _names = null;

        public static List<string> Names
        {
            get
            {
                return local.Value._names;
            }
        }
        private static StateDataCache GetData()
        {
            DAO ObjDAO = new DAO();
            StateDataCache cache = new StateDataCache();
            cache._names = ObjDAO.GetStates();
            Console.WriteLine("GetData Method Called");
            return cache;
        }


    }
}
