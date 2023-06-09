using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _StaffService;

        public StaffController(IStaffService StaffService)
        {
            _StaffService = StaffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _StaffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff Staff)
        {
            _StaffService.TInsert(Staff);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }

        [HttpPost("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();
        }
    }
}
