using ToDoList.Service.Validators;
using FluentValidation;

namespace ToDoList.Api.Configurations;

public static class FluentValidatorsDependecyI
{
    public static void AddFluentValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<ToDoItemCreateDtoValidator>();
    }
}
