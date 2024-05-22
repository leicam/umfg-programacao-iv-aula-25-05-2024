namespace UMFG.Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutarBasicEvent();
        }

        private static void ExecutarBasicEvent()
        {
            var publisher = new EventPublisher();
            var publisherEventHandler = new PublisherEventHandler(OnValueChange);
            publisher.publisherEvent += publisherEventHandler;

            var value = string.Empty;
            do
            {
                Console.WriteLine("Ola, informe uma palavra: ");
                value = Console.ReadLine();

                if (!value.Equals("Sair"))
                {
                    publisher.Value = value;
                }
            } while (!value.Equals("Sair"));

            Console.WriteLine("Ate logo");
        }

        private static void OnValueChange(string value)
            => Console.WriteLine($"O valor mudou para: {value}");
    }
}