using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
