namespace middleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from first middlware!\n");
                await next();
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from second middlware!");
            });

            app.Run();
        }
    }
}
