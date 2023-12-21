
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoftShoes;
using SoftShoes.Core.Implementations;
using SoftShoes.Core.Interfaces;
using SoftShoes.UI;

public class Program
{
    private readonly IDisplay _display;
    public Program(IDisplay display)
    {
        _display = display;
    }

    private static void Main(string[] args)
    {


        var host = Host.CreateDefaultBuilder()
                                 .ConfigureServices((context, services) =>
                                 {

                                     services.AddScoped<IDisplay, Display>();
                                 }).Build();
        var program = ActivatorUtilities.CreateInstance<Program>(host.Services);
        program.Run();
    }
    public void Run()
    {


        _display.Menu();

    }
}