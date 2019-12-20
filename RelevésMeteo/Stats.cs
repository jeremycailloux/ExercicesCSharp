
using System;
using System.Collections.Generic;
using System.Text;

namespace RelevésMeteo
{
    class Stats
    {

        public RelevéMensuel ReleveTempMax { get; set; }
        public Stats(List<RelevéMensuel> relevés)
        {
            float tmax = 0;
            foreach (var item in relevés)
            {
                if (item.TMax > tmax)
                {
                    tmax = item.TMax;
                }
            }
        }
    }
    
}
