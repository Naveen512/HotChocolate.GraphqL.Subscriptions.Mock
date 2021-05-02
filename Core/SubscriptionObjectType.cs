using HotChoco.Pub.Sub.InMemo.Models;
using HotChocolate;
using HotChocolate.Types;

namespace HotChoco.Pub.Sub.InMemo.Core
{
    public class SubscriptionObjectType
    {

        [Topic]
        [Subscribe]
        public Product SubscribeProduct([EventMessage] Product product)
        {
            return product;
        }
    }
}