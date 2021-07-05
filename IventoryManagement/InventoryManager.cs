using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IventoryManagement
{
    //implementing interface
    class InventoryManager  : Interface1
    {
        /// <summary>
        /// Adds to inventory method.
        /// </summary>
        int totalpulseInventory = 0;
        int totalwheatInventory = 0;
        int totalriceInventory = 0;
        public List<Rice> AddToInventory(List<Rice> ricelist)
        {
            Rice rice = new Rice();
            Console.WriteLine("Enter the rice name: ");
            rice.name = Console.ReadLine();
            Console.WriteLine("Enter the rice price: ");
            rice.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice weight: ");
            rice.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice type: ");
            rice.type = Console.ReadLine();
            ricelist.Add(rice);
            return ricelist;
        }
        public List<Wheat> AddToInventory(List<Wheat> wheatlist)
        {
            Wheat wheat = new Wheat();
            Console.WriteLine("Enter the wheat name: ");
            wheat.name = Console.ReadLine();
            Console.WriteLine("Enter the wheat price: ");
            wheat.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat weight: ");
            wheat.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat type: ");
            wheat.type = Console.ReadLine();
            wheatlist.Add(wheat);
            return wheatlist;

        }
        public List<Pulses> AddToInventory(List<Pulses> pulselist)
        {
            Pulses pulse = new Pulses();
            Console.WriteLine("Enter the pulse name: ");
            pulse.name = Console.ReadLine();
            Console.WriteLine("Enter the pulse price: ");
            pulse.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse weight: ");
            pulse.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse type: ");
            pulse.type = Console.ReadLine();
            pulselist.Add(pulse);
            return pulselist;

        }
        /// <summary>
        /// Deletes from inventory.
        /// </summary>
        
        public List<Rice> DeleteFromInventory(List<Rice> ricelist)
        {
            
            Console.WriteLine("Enter the name of the rice to be modified or deleted:");
            string ricename = Console.ReadLine();
            ricelist.Remove(ricelist.Find(result => result.name.Equals(ricename)));
            return ricelist;
        }
        public List<Wheat> DeleteFromInventory(List<Wheat> wheatlist)
        {
            
            Console.WriteLine("Enter the name of the wheat to be modified or deleted:");
            string wheatname = Console.ReadLine();
            wheatlist.Remove(wheatlist.Find(result => result.name.Equals(wheatname)));
            return wheatlist;
        }
        public List<Pulses> DeleteFromInventory(List<Pulses> pulselist)
        {
            Console.WriteLine("Enter the name of the pulse to be modified or deleted:");
            string pulsename = Console.ReadLine();
            pulselist.Remove(pulselist.Find(result => result.name.Equals(pulsename)));
            return pulselist;
        }
        /// <summary>
        /// Updates the inventory.
        /// </summary>
       
        public List<Rice> UpdateInventory(List<Rice> ricelist)
        {
            return AddToInventory(DeleteFromInventory(ricelist));

        }
       public List<Wheat> UpdateInventory(List<Wheat> wheatlist)
        {
            return AddToInventory(DeleteFromInventory(wheatlist));
        }
        public List<Pulses> UpdateInventory(List<Pulses> pulselist)
        {
            
           return AddToInventory(DeleteFromInventory(pulselist));
            
        }

        /// <summary>
        /// Displays the content in inventory.
        /// </summary>
        public void DisplayTheContentInInventory(List<Rice> ricelist)
        {
           
            Console.WriteLine("***   Rice Varieties   ***");
            foreach(var rices in ricelist)
            {
                Console.WriteLine("Rice Name: {0}",rices.name);
                Console.WriteLine("Rice Price: {0}", rices.price);
                Console.WriteLine("Rice Weight: {0}", rices.weight);
                Console.WriteLine("Rice Type: {0}", rices.type);
                Console.WriteLine(" ");
                totalriceInventory += InventoryCost(rices.price,rices.weight);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Total Rice Cost: {0}", totalriceInventory);
     
        }
        public void DisplayTheContentInInventory(List<Wheat> wheatlist)
        {
            
            Console.WriteLine("***   Wheat Varieties   ***");
            foreach (var wheats in wheatlist)
            {
                Console.WriteLine("Wheat Name: {0}", wheats.name);
                Console.WriteLine("Wheat Price: {0}", wheats.price);
                Console.WriteLine("Wheat Weight: {0}", wheats.weight);
                Console.WriteLine("Wheat Type: {0}", wheats.type);
                Console.WriteLine(" ");
                totalwheatInventory += InventoryCost(wheats.price,wheats.weight);

            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Total Wheat Cost: {0}", totalwheatInventory);

        }
        public void DisplayTheContentInInventory(List<Pulses> pulselist)
        {
            
            Console.WriteLine("***   Pulse Varieties   ***");
            foreach (var pulses in pulselist)
            {
                Console.WriteLine("Pulse Name: {0}", pulses.name);
                Console.WriteLine("Pulse Price: {0}", pulses.price);
                Console.WriteLine("Pulse Weight: {0}", pulses.weight);
                Console.WriteLine("Pulse Type : {0}", pulses.type);
                Console.WriteLine(" ");
                totalpulseInventory += InventoryCost(pulses.price,pulses.weight);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Total Pulse Cost: {0}", totalpulseInventory);
        }
        public int InventoryCost(int price,int weight)
        {
            return weight * price;

        }
        /// <summary>
        /// Inventories the details with total inventory cost.
        /// </summary>
        /// <param name="ricelist">The ricelist.</param>
        /// <param name="wheatlist">The wheatlist.</param>
        /// <param name="pulselist">The pulselist.</param>
        public void InventoryDetails(List<Rice> ricelist,List<Wheat> wheatlist,List<Pulses> pulselist)
        {
            DisplayTheContentInInventory(ricelist);
            DisplayTheContentInInventory(wheatlist);
            DisplayTheContentInInventory(pulselist);
            Console.WriteLine(" ");
            Console.WriteLine("The total inventory cost is "+(totalpulseInventory+totalriceInventory+totalwheatInventory));
            
        }

    }
}
