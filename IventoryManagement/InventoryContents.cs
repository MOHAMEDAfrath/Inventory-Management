using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IventoryManagement
{

    /// <summary>
    /// Storing data in objects.
    /// </summary>
    class InventoryContents
    {
        public List<Rice> ricelist
        {
            get;
            set;
        }
        public List<Wheat> wheatlist
        {
            get;
            set;
        }
        public List<Pulses> pulselist
        {
            get;
            set;
        }


    }
    public class Rice
    {
        public string name
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
        public int weight
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }


    }
    public class Wheat
    {
        public string name
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
        public int weight
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }


    }
    public class Pulses
    {
        public string name
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
        public int weight
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }


    }

}
