using System;

namespace GameProjectt
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Özge",
                LastName = "Aktaş",
                IdentityNumber = 12345
            });

           
          
            OrderManager orderManager = new OrderManager();
            Campaign campaign = new Campaign();
            campaign.CampaignName = "indirim kampanyası";
            campaign.CampaignDiscount = 15;
            orderManager.CampaignSystem(campaign);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
        }
    }
}
