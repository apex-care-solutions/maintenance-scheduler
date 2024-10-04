using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class SubscriptionService
    {
        private readonly Repository<Subscription> SubscriptionRepository;

        public SubscriptionService(Repository<Subscription> SubscriptionRepository){
            this.SubscriptionRepository = SubscriptionRepository;
        }
        public async Task<Subscription> GetSubscriptionsAsync(){
            return null;
        }

        public async Task<Subscription[]> GetSubscriptionsAsync(Expression<Func<Subscription, bool>>? filter = null){
            return null;
        }

        public async Task<Subscription> CreateSubscriptionAsync(Subscription Subscriptions){
            return null;
        }

        public async Task<Subscription[]> CreateSubscriptionsAsync(Subscription[] Subscriptions){
            return null;
        }

        public async Task<Subscription> UpdateSubscriptionAsync(Subscription Subscriptions){
            return null;
        }

        public async Task<Subscription[]> UpdateSubscriptionsAsync(Subscription[] Subscriptions){
            return null;
        }
    }
}