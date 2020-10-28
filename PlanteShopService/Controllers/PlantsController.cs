using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlanteShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {

        public static List<Plante> PlantList = new List<Plante>()
        {
            new Plante(1, "Rose", "Albertine", 400, 199),
            new Plante(2, "Busk", "Aronia", 200, 169),
            new Plante(3, "FrugtOgBaer", "AromaAeble", 350, 399)
        };
        // GET: api/Plants
        [HttpGet]
        public IEnumerable<Plante> GetAllPlants()
        {
            return PlantList;
        }

        // GET: api/Plants/5
        [HttpGet]
        [Route("{id}")]
        public Plante GetPlantByID(int id)
        {
            return PlantList.Find(i => i.PlanteID == id);
        }


        // POST: api/Plants 
        [HttpPost]
        public int AddPlant(Plante plant)
        {
            int NewID = PlantList.Max(c => c.PlanteID) + 1;
            plant.PlanteID = NewID;
            PlantList.Add(plant);
            return plant.PlanteID;
        }

        [HttpGet]
        [Route("Type/{type}")]
        public IEnumerable<Plante> GetPlantByType(string type)
        {

            return PlantList.FindAll(i => i.PlanteType.Contains(type));
        }


    }
}
