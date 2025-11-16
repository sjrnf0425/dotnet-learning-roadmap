var controller = new HelloController(new MessageService());
controller.Print();

var controller2 = new HelloController(new MessageService2());
controller2.Print();

public interface IMessageService
{
    string GetHelloMessage();
    string GetKnowMessage();
}

public class MessageService : IMessageService
{
    public string GetHelloMessage() => "Hello, Dependency Injection!";
    public string GetKnowMessage() => "I Know Dpendency Injection maybe";
}

public class MessageService2 : IMessageService
{
    public string GetHelloMessage() => "Hello, DI";
    public string GetKnowMessage() => "I don't know Dpendency Injection maybe";
}


public class HelloController
{
    private readonly IMessageService _messageService;

    public HelloController(IMessageService messageSerivce)
    {
        _messageService = messageSerivce;
    }

    public void Print()
    {
        Console.WriteLine(_messageService.GetHelloMessage());
        Console.WriteLine(_messageService.GetKnowMessage());
    }
}
