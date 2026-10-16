// RaceDay.Api/Program.cs
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<RaceDayContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddControllers();
        var app = builder.Build();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
