using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_EEDD2Tr
{
    internal class ChemicalElement
    {
        public string name;
        public string atomicNumber;
        public string atomicMass;
        public string neutrons;
        public string protons;
        public string electrons;

        public ChemicalElement(string name, string atomicNumber,string atomicMass,
            string neutrons,string protons,string electrons) 
        {
            this.name = name;
            this.atomicNumber = atomicNumber;
            this.atomicMass = atomicMass;
            this.neutrons = neutrons;
            this.protons = protons;
            this.electrons = electrons;
        }
    }
}
