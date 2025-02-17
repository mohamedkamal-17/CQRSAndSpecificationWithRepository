using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Command.AddEmployee;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetAllIncludeProjectOrderById;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByIdWithProjects;
using CQRSAndSpecificationWithRepository.Aplication.Feature.Employees.Query.GetEmployeeByNameIncludeProjectAndDepartment;
using MediatR;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRSAndSpecificationWithRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee(IMediator mediator) : ControllerBase
    {


        // GET api/<Employee>/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await mediator.Send(new GetEmployeeByIdIncludProjectQuery() { Id = id });
            if (employee is null) { return NotFound(); }
            return Ok(employee);
        }

        // GET api/<Employee>/name
        [HttpGet("{name}")]
        public async Task<IActionResult> GetEmployeeByName(string name)
        {
            var employee = await mediator.Send(new GetEmployeeByNameIncludeProjectAndDepartmentQuery() { Name = name });
            if (employee is null) return NotFound();
            return Ok(employee);
        }

        // POST api/<Employee>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var meployees = await mediator.Send(new GetAllIncludeProjectOrderByIdQuery());
            return Ok(meployees);
        }


        // POST api/<Employee>
        [HttpPost]
        public void Add(AddEmployeeCommand command)
        {
            mediator.Send(command);
        }



    }
}
