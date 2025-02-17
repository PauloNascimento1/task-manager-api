using System;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Infraestructure.Interfaces;

public interface ITaskService
{
    Task<bool> CreateTask(TaskItemModel task);
}
