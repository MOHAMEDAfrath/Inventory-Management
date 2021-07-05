using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IventoryManagement
{
    /// <summary>
    /// Interface with method decalarations.
    /// </summary>
    interface Interface1
    {
        void DisplayTheContentInInventory(List<Rice> ricelist);
        void DisplayTheContentInInventory(List<Wheat> wheatlist);
        void DisplayTheContentInInventory(List<Pulses> pulselist);

        List<Rice> AddToInventory(List<Rice> ricelist);
        List<Wheat> AddToInventory(List<Wheat> wheatlist);
        List<Pulses> AddToInventory(List<Pulses> pulselist);
        List<Rice> DeleteFromInventory(List<Rice> ricelist);
        List<Wheat> DeleteFromInventory(List<Wheat> wheatlist);
        List<Pulses> DeleteFromInventory(List<Pulses> pulselist);
        List<Rice> UpdateInventory(List<Rice> ricelist);
        List<Wheat> UpdateInventory(List<Wheat> wheatlist);
        List<Pulses> UpdateInventory(List<Pulses> pulselist);

    }
}
