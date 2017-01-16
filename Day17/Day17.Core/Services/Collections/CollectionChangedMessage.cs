using MvvmCross.Plugins.Messenger;

namespace Day17.Core.Services.Collections
{
    public class CollectionChangedMessage : MvxMessage
    {
        public CollectionChangedMessage(object sender) : base(sender)
        {
        }
    }
}