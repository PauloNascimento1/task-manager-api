using System;
using TaskManagerAPI.Infraestructure.Context;
using TaskManagerAPI.Infraestructure.Interfaces;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Infraestructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly AppDbContext _context;

    public TaskRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateTaskAsync(TaskItemModel task)
    {
        try
        {
            task.CreatedDate = DateTime.Now;

            await _context.Tarefas.AddAsync(task);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return false;
        }

        return true;
    }
}
