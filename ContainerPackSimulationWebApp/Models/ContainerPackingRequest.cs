using System;
using System.Collections.Generic;

using ContainerPackSimulationWebApp.Entities;

namespace ContainerPackSimulationWebApp.Models
{
    public class ContainerPackingRequest
    {
        public List<Container> Containers { get; set; }

        public List<Item> ItemsToPack { get; set; }

        public List<int> AlgorithmTypeIDs { get; set; }
    }
}
