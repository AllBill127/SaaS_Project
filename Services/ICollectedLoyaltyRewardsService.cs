using System;
using System.Collections.Generic;
using PSP.Models;

namespace PSP.Services;

public interface ICollectedLoyaltyRewardsService
{
    List<CollectedLoyaltyReward> GetAll();

    CollectedLoyaltyReward GetById(Guid guid);
    
    CollectedLoyaltyReward Create(CollectedLoyaltyReward collectedLoyaltyReward);
    
    void Delete(Guid guid);
}