var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/dividir/handle", (int a, int b) =>
{
    try
    {
      
        int result = a / b;
        return result;

    }
    catch (DivideByZeroException ex){
        throw ex;
    }
});

app.MapGet("/dividir", (int a, int b) =>
{
   if (a == 0 || b == 0) return 0;

    return a / b;
  
});


app.Run();
