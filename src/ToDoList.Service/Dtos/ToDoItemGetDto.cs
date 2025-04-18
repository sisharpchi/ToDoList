﻿namespace ToDoList.Service.Dtos;

public class ToDoItemGetDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplited { get; set; }
}
