// using Microsoft.AspNetCore.Mvc;
// using SimpleAPI.Model;



// namespace  SimpleAPI.controllers
// {
//     [Route("api/commands")]
//     [ApiController]
//     public class CommandsController : ControllerBase
//     {
//         private readonly MockCommanderRepo _repository = new MockCommanderRepo();
//         //Get api/commands
//         [HttpGet]
//         public ActionResult <IEnumerable<Command>> GetAllCommands()
//         {
//            var commandItems = _repository.GetAppCommands();

//            return OK(commandItems);
//         }
//         //Get api/command
//         [HttpGet("{id}")]
//         public ActionResult <Command> GetCommandById(int id)
//         {
//             var commandItem = _repository.GetCommandById(id);
            
//             return OK(commandItem);
//         }
//     }
// }