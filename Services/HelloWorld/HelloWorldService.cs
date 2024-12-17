namespace Services.HelloWorld
{
    public class HelloWorldService : IHelloWorldService
    {
        public void Hello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
