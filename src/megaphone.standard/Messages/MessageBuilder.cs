namespace Megaphone.Standard.Messages
{
    public class MessageBuilder
    {
        private readonly CommandMessage e;

        private MessageBuilder(string name) => e = new CommandMessage() { Name = name };

        public static MessageBuilder NewCommand(string name)
        {
            var b = new MessageBuilder(name);
            return b;
        }

        public MessageBuilder WithMetadata(string name, string value)
        {
            e.Metadata.Add(name, value);
            return this;
        }

        public MessageBuilder WithParameters(string name, string value)
        {
            e.Parameters.Add(name, value);
            return this;
        }

        public CommandMessage Make()
        {
            return e;
        }
    }
}