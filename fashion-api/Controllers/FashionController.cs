using fashion_api.Interfaces;
using fashion_api.Models;
using Microsoft.AspNetCore.Mvc;
using shared;
using System.Collections.Generic;

namespace fashion_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FashionController : ControllerBase
    {
        private readonly IFashionServices _fashionServices;

        public FashionController(IFashionServices fashionServices)
        {
            _fashionServices = fashionServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FashionQueryResult>> GetAll()
        {
            return Ok(_fashionServices.GetAll());
        }

        [HttpPost]
        public ActionResult<Result> Create(FashionCommand book)
        {
            var response = _fashionServices.Create(book);
            return response.HasError
                ? BadRequest(response)
                : Ok(response);
        }
    }
}