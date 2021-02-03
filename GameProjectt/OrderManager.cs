using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class OrderManager
    {
        
        public void CampaignSystem(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanyamız" + campaign.CampaignDiscount + "% indirimle eklenmiştir");
        }


    }
}
