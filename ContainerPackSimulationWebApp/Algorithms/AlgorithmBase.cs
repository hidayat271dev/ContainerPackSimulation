using System;
using System.Collections.Generic;

using ContainerPackSimulationWebApp.Entities;

namespace ContainerPackSimulationWebApp.Algorithms
{
    public abstract class AlgorithmBase
    {
        public abstract ContainerPackingResult Run(Container container, List<Item> items);
    }
}
