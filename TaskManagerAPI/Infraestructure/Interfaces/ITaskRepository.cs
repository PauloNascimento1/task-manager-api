using System;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Infraestructure.Interfaces;

public interface ITaskRepository
{
    Task<bool> CreateTaskAsync(TaskItemModel task);
}
