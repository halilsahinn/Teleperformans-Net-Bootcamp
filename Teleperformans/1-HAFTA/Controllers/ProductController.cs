using Hafta1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hafta1.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            #region FIELDS
            private static List<ProductModel> lstproduct = new List<ProductModel>()
        {
         new ProductModel { Id = 1, ProductName = "Bilgisayar", CategoryName = "Elektronik Eşyalar", Price = 12.00 },
         new ProductModel { Id = 2, ProductName = "Cep Telefonu", CategoryName = "Elektronik Eşyalar", Price = 8.00 },
         new ProductModel { Id = 3, ProductName = "Tablet", CategoryName = "Elektronik Eşyalar", Price = 4.00 }


        };
            #endregion

            #region CTOR
            public ProductController()
            {



            }
            #endregion

            #region IACTION RESULTS

            #region GET
            [HttpGet]
            public IActionResult GetAll()
            {
                if (lstproduct.Count != 0)
                {
                    return Ok(lstproduct);
                }

                return NotFound("Listelenecek Kayıt Bulunamadı");

            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {

                var result = lstproduct.Where(x => x.Id == id).SingleOrDefault();

                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound("Kayıt Bulunamadı");

            }

            #endregion

            #region CREATE

            [HttpPost]
            public IActionResult Create([FromBody] ProductModel product)
            {

                try
                {
                    if (ModelState.IsValid)
                    {
                        lstproduct.Add(product);
                    }

                    return Created("~api/products", product);
                }
                catch (Exception ex)
                {

                    return BadRequest(ex);
                }



            }

            #endregion

            #region UPDATE
            [HttpPut]
            public IActionResult Update([FromBody] ProductModel product)
            {

                try
                {
                    var result = lstproduct.SingleOrDefault(x => x.Id == product.Id);
                    if (product is not null)
                    {
                        result.ProductName = product.ProductName;
                        result.CategoryName = product.CategoryName;
                        result.Price = product.Price;

                    }
                    else
                    {
                        return NotFound();
                    }
                    return NoContent();
                }
                catch (Exception ex)
                {

                    return BadRequest(ex);
                }



            }

            [HttpPatch("{id}")]
            public IActionResult Patch(int id, string productName)
            {
                var product = lstproduct.SingleOrDefault(x => x.Id == id);

                if (product != null)
                {

                    lstproduct.SingleOrDefault(g => g.Id == id).ProductName = productName;
                }
                else
                {
                    return NotFound();
                }
                return NoContent();


            }

            #endregion

            #region DELETE
            [HttpDelete("Id")]
            public IActionResult Delete(int Id)
            {
                var product = lstproduct.Find(x => x.Id == Id);
                lstproduct.Remove(product);
                return NoContent();

            }

            #endregion

            #region SORT
            [HttpGet("sort")]
            public IActionResult SortProduct([FromQuery] string sortProduct)
            {

                switch (sortProduct)
                {

                    case "ByName":
                        return Ok(lstproduct.OrderBy(x => x.ProductName).ToArray());

                    case "ByCategoryName":
                        return Ok(lstproduct.OrderBy(x => x.CategoryName).ToArray());

                    case "ByPrice":
                        return Ok(lstproduct.OrderBy(x => x.Price).ToArray());

                    default:
                        return NotFound();
                }


            }

            #endregion

            #endregion

        }
    
}
