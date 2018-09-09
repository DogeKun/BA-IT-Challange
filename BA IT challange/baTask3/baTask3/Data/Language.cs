using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baTask3
{
    class Language
    {
        public string LAN_LABEL;
        public int LAN_ID;
        public int FREE_SPACE;

        public Language(string LAN_LABEL, int LAN_ID, int FREE_SPACE)
        {
            this.LAN_LABEL = LAN_LABEL;
            this.LAN_ID = LAN_ID;
            this.FREE_SPACE = FREE_SPACE;
        }

        /*
         * Returns the percentage of total school children with the language they are learning
         */
        public float Percentage(int TOTAL_FREE_SPACE)
        {
            float percentage = (float) FREE_SPACE / (float) TOTAL_FREE_SPACE * 100f;
            
            return (float)Math.Round(percentage, 2);
        }
    }
}
