using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ContainerPackSimulationWebApp.Services;
using ContainerPackSimulationWebApp.Algorithms;
using ContainerPackSimulationWebApp.Entities;
using ContainerPackSimulationWebApp.Models;

namespace ContainerPackSimulationWebApp.Controllers
{
    public class ContainerPackingController: Controller
    {
        public ContainerPackingController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Posts the specified packing request.
        /// </summary>
        /// <param name="request">The packing request.</param>
        /// <returns>A container packing result with lists of packed and unpacked items.</returns>
        [HttpPost]
        public List<ContainerPackingResult> Index([FromBody]ContainerPackingRequest request)
        {
            return PackingService.Pack(request.Containers, request.ItemsToPack, request.AlgorithmTypeIDs);
        }
    }
}
