using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Infraestructure.Interfaces;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] TaskItemModel task)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (string.IsNullOrEmpty(task.Description))
            return BadRequest("A descrição é obrigatória.");


        var isSuccessful = await _taskService.CreateTask(task);

        if (!isSuccessful)
            return Problem("Erro ao criar a tarefa.");

        return Created("Tarefa criada.", task);
    }


}

