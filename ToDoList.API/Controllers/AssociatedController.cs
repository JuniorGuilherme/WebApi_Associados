using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoList.API.DTOs;
using ToDoList.Domain;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    public class AssociatedController : ControllerBase
    {
        private readonly IAssociatedRepository repository;
        public AssociatedController(IAssociatedRepository repository){
            this.repository = repository;
        }
        // GET api/todos
        [HttpGet]
        public IEnumerable<AssociatedDTO> Get()
        {
            var ass = this.repository.GetAll();
            var assDTO = new List<AssociatedDTO>();

            ass.ForEach(item => {
                assDTO.Add(
                    new AssociatedDTO{
                        id = item.id, 
                        name = item.name
                    }
                );
            });

            return assDTO;

            // var users = this.repository.GetAll();
            // List<UserDTO> usersDTo = new List<UserDTO>();    
            // foreach (var item in users)
            // {
            //     var objDTO = new UserDTO
            //     {
            //          id = item.id,
            //          name = item.name
            //     };
            //     usersDTo.Add(objDTO);
            // }

            // return usersDTo;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Associated Get(int id)
        {
            return this.repository.GetById(id);
        }

        // POST api/Todos
        [HttpPost]
        public IActionResult Post([FromBody]Associated item)
        {
            //caso nao grave
            if (ModelState.IsValid)
            {
                    this.repository.Create(item);
                    return Ok(item);
            }
            else
            {
                //ARRAY STRINGS ERROS
                var errors = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }

                return BadRequest(new {
                    code = 401,
                    message = errors
                });
            }
        }

        // PUT api/Todos/
        [HttpPut]
        public IActionResult Put([FromBody]Associated item)
        {
            this.repository.Update(item);
            return Ok(item);
        }

        // DELETE api/Todos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.repository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso.",
                id = id
            });
        }
    }
}