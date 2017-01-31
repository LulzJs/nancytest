using Nancy;
  
namespace NancyApplication
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello from Nancy ");
            Get("/test/{name}/{surname}", args => new Person() { 
                Name = args.name, 
                Surname = args.surname});
        }
    }
 
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}