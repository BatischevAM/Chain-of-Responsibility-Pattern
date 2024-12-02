using Chain_of_Responsibility_Pattern;

public class Program
{
    public static void Main(string[] args)
    {
        var clickHandler = new ClickEventHandler();
        var keyPressHandler = new KeyPressEventHandler();
        var mouseOverHandler = new MouseOverEventHandler();

        clickHandler.SetNext(keyPressHandler);
        keyPressHandler.SetNext(mouseOverHandler);

        var requests = new List<EventRequest>
        {
            new EventRequest(EventType.Click, "Кнопка нажата"),
            new EventRequest(EventType.KeyPress, "Клавиша A нажата"),
            new EventRequest(EventType.MouseOver, "Мышь наведена на элемент"),
            new EventRequest(EventType.Click, "Другой клик")
        };

        foreach (var request in requests)
        {
            clickHandler.HandleRequest(request);
            Console.WriteLine();
        }
    }
}