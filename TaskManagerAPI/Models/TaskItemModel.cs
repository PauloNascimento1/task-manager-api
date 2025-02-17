using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models;

public class TaskItemModel
{
    [Key]
    public int TaskId { get; set; }
    [Required]
    [StringLength(100)]
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now.ToLocalTime();
}
