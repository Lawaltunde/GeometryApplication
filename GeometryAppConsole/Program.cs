using System.Configuration;
using GeometryApp.GeometryAppLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};
IConfiguration configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

//settingUP Dependency Injection

IServiceCollection services = new ServiceCollection();

//setting up feature management

services.AddFeatureManagement(configuration);

//Creating instance class

IServiceProvider serviceProvider = services.BuildServiceProvider();

//Control Access to Shape classes

IFeatureManager featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

//Condition to check if Square and Triangle are turned ON
if(await featureManager.IsEnabledAsync("Square") && await featureManager.IsEnabledAsync("Triangle")){
    double result;
    
    Console.WriteLine("Enter value for Lenght");

    //string? lenght = Console.ReadLine(); 

    if(double.TryParse(Console.ReadLine(), out result)){
        Square square = new Square(result);
        Console.WriteLine("Area of Square is: {0}msqr ", square.CalculateArear());
        Console.WriteLine("Perimeter of Square is: {0}m", square.CalculatePerimeter());
    }
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Enter value for base");
            var getBase = Console.ReadLine();

            Console.WriteLine("Enter value for height");
            var height = Console.ReadLine();
            double baseResult;
            double heightthResult;
    
        if(double.TryParse(getBase, out baseResult))
        {
            if(double.TryParse(height, out heightthResult)){
                Triangle triangle = new Triangle(baseResult, heightthResult);
                Console.WriteLine("Area of a triangle is: {0}msqr", triangle.CalculateArear());
                Console.WriteLine("Perimeter of a triangle is: {0}m", triangle.CalculatePerimeter());      
            }
        }


}

//Condition to check if Square and Rectangle are turned ON
else
    if(await featureManager.IsEnabledAsync("Square") && await featureManager.IsEnabledAsync("Rectangle")){
        double result;
    
        Console.WriteLine("Enter value for Lenght");

        if(double.TryParse(Console.ReadLine(), out result)){
            Square square = new Square(result);
            Console.WriteLine("Area of Square is: {0}msqr ", square.CalculateArear());
            Console.WriteLine("Perimeter of Square is: {0}m ", square.CalculatePerimeter());
        }
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        double lenghtResult;
        double breadthResult;
    
        Console.WriteLine("Enter value for Lenght");
        var lenght = Console.ReadLine();

        Console.WriteLine("Enter value for Breadth");
        var breadth = Console.ReadLine();
          
        if(double.TryParse(lenght, out lenghtResult))
        {
            if(double.TryParse(breadth, out breadthResult)){
                Rectangle rectangle = new Rectangle(lenghtResult, breadthResult);
                Console.WriteLine("Area of rectangle is: {0}msqr ", rectangle.CalculateArear());
                Console.WriteLine("Perimeter of rectangle is: {0}m ", rectangle.CalculatePerimeter());
            }
        }
    }

//Condition checking if only Square is turned ON
else 
    if (await featureManager.IsEnabledAsync("Square"))
    {
        double result;
    
        Console.WriteLine("Enter value for Lenght");

        //string? lenght = Console.ReadLine(); 

        if(double.TryParse(Console.ReadLine(), out result)){
            Square square = new Square(result);
            Console.WriteLine("Area of Square is: {0}msqr ", square.CalculateArear());
            Console.WriteLine("Perimeter of Square is: {0}m ", square.CalculatePerimeter());
        }
    }

//Condition checking if only Rectangle is turned ON
else 
    if (await featureManager.IsEnabledAsync("Rectangle"))
    {
        double lenghtResult;
        double breadthResult;
    
        Console.WriteLine("Enter value for Lenght");
        var lenght = Console.ReadLine();

        Console.WriteLine("Enter value for Breadth");
        var breadth = Console.ReadLine();
          
        if(double.TryParse(lenght, out lenghtResult))
        {
            if(double.TryParse(breadth, out breadthResult)){
                Rectangle rectangle = new Rectangle(lenghtResult, breadthResult);
                Console.WriteLine("Area of rectangle is: {0}msqr ", rectangle.CalculateArear());
                Console.WriteLine("Perimeter of rectangle is: {0}m ", rectangle.CalculatePerimeter());
            }
        }
    }

//Condition checking if only Triangle is turned ON
    else
        if(await featureManager.IsEnabledAsync("Triangle")){
            Console.WriteLine("Enter value for base");
            var getBase = Console.ReadLine();

            Console.WriteLine("Enter value for height");
            var height = Console.ReadLine();
            double baseResult;
            double heightthResult;
    
        if(double.TryParse(getBase, out baseResult))
        {
            if(double.TryParse(height, out heightthResult)){
                Triangle triangle = new Triangle(baseResult, heightthResult);
                Console.WriteLine("Area of a triangle is {0}: msqr", triangle.CalculateArear());
                Console.WriteLine("Perimeter of a triangle is: {0}m ", triangle.CalculatePerimeter());      
            }
        }
    }

    //Checking for Exception 
     else
        {
            Console.WriteLine("Wrong choice!!");
        }
        