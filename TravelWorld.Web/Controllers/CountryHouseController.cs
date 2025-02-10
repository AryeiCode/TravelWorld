using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWorld.Domain.Entities;
using TravelWorld.Infrastructure.Data;

namespace TravelWorld.Web.Controllers
{
    public class CountryHouseController : Controller
    {
        private readonly AppDbContext _db;

        public CountryHouseController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var countryHouse = _db.CountryHouses.ToList();
            return View(countryHouse);
        }

        /*combinación de las palabras “update” (actualizar) e “insert” (insertar)*/
        public IActionResult Upsert(int countryHouseId)
        {
            if (countryHouseId != 0)
            {
                var obj = _db.CountryHouses.FirstOrDefault(x => x.Id == countryHouseId);
                return View(obj);
            }

            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Upsert(CountryHouse obj)
        {
            /*if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("description", "No puede existir una descripción igual al nombre");
            }*/
            var error = ModelState.Values;


            if (ModelState.IsValid)
             {
                if (obj.Id == 0)
                {
                    _db.CountryHouses.Add(obj);
                    _db.SaveChanges();
                }
                else
                {
                    _db.CountryHouses.Update(obj);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        //TODO: Refrescar la tabla cuando se elimina
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int countryHouseId, bool res)
        {
            var obj = _db.CountryHouses.FirstOrDefault(x => x.Id == countryHouseId);
            if (obj != null && res)
            {              
                _db.CountryHouses.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
