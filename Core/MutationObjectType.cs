using System;
using System.Threading.Tasks;
using HotChoco.Pub.Sub.InMemo.Models;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace HotChoco.Pub.Sub.InMemo.Core
{
    public class MutationObjectType
    {
        public async Task<string> AddProduct(
            [Service] ITopicEventSender eventSender,
            Product model)
        {
            // add your own logic to saving data into some data store.
            model.CreatedDate = DateTime.Now;
            await eventSender.SendAsync(nameof(SubscriptionObjectType.SubscribeProduct), model);
            return model.Name;
        }
    }
}