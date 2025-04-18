﻿using Microsoft.EntityFrameworkCore;
using ToDoList.Dal;

namespace ToDoList.Api.Configurations;

public static class DataBaseConnection
{
    public static void AddDataBaseConnection(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

        builder.Services.AddDbContext<MainContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
