using System;
using System.Collections.Generic;
using System.Text;

namespace baTask3
{
    class SchoolData
    {
        public int DARZ_ID;
        public string SCHOOL_NAME;

        public int TYPE_ID;
        public string TYPE_LABEL;

        public int LAN_ID;
        public string LAN_LABEL;

        public int CHILD_COUNT;
        public int FREE_SPACE;

        public SchoolData(int DARZ_ID,string SCHOOL_NAME, int TYPE_ID, string TYPE_LABEL, 
            int LAN_ID, string LAN_LABEL, int CHILD_COUNT, int FREE_SPACE)
        {
            this.DARZ_ID = DARZ_ID;
            this.SCHOOL_NAME = SCHOOL_NAME;

            this.TYPE_ID = TYPE_ID;
            this.TYPE_LABEL = TYPE_LABEL;

            this.LAN_ID = LAN_ID;
            this.LAN_LABEL = LAN_LABEL;

            this.CHILD_COUNT = CHILD_COUNT;
            this.FREE_SPACE = FREE_SPACE;   
        }
    }
}
