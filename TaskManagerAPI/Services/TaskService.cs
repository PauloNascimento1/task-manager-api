using System;
using TaskManagerAPI.Infraestructure.Interfaces;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> CreateTask(TaskItemModel task)
    {
        bool isSuccessful = false;

        try
        {
            isSuccessful = await _taskRepository.CreateTaskAsync(task);
        }
        catch (Exception ex)
        {
            return false;
        }

        return isSuccessful;
    }

}
