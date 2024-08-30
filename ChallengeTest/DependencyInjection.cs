using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(x =>
            x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("ChallengeTest")));

        return builder;
    }

    public static WebApplicationBuilder AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        builder.Services.AddRouting(options => options.LowercaseUrls = true);

        builder.Services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Code Challenge",
                Description = "This is the API for the Code Challenge"
            });

            s.DescribeAllParametersInCamelCase();

            s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Please enter your Bearer token in the format: Bearer {token}"
            });

            s.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });

        return builder;
    }
}
