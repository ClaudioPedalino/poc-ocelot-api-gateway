using electronic_api.Interfaces;
using electronic_api.Models;
using Microsoft.AspNetCore.Mvc;
using shared;
using System.Collections.Generic;

namespace electronic_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IPhoneService _phoneService;

        public PhonesController(IPhoneService bookService)
        {
            _phoneService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PhoneQueryResult>> GetAll()
        {
            return Ok(_phoneService.GetAll());
        }

        [HttpPost]
        public ActionResult<Result> Create(PhoneCommand book)
        {
            var response = _phoneService.Create(book);
            return response.HasError
                ? BadRequest(response)
                : Ok(response);
        }
    }
}