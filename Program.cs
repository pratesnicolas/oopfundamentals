// See https://aka.ms/new-console-template for more information
using Balta.ContentContext;
using Balta.SubscriptionContext;

Console.WriteLine("Hello, World!");

var articles = new List<Article>();
articles.Add(new Article("Artigo Sobre OOP", "orientacao-objetos"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
}

var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCSharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem2 = new CareerItem(2, "Aprenda .NET", "", null);
var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
var careerItem3 = new CareerItem(3, "OOP", "", courseAspNet);

careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);
        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
    var paypalSubcription = new PaypalSubscription();
    var student = new Student();
    student.CreateSubscription(paypalSubcription);
}
