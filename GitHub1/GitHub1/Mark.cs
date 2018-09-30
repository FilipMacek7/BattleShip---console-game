using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub1
{
    class Mark
    {
        public int _markPosX = 0;
        public int _markPosY = 0;
        public int markPosX
        {
            get
            {
                return _markPosX;
            }
            set
            {
                if (value < 0 || value > 9)
                {
                    return;
                }
                _markPosX = value;
            }
        }
        public int markPosY
        {
            get
            {
                return _markPosY;
            }
            set
            {
                if (value < 0 || value > 9)
                {
                    return;
                }
                _markPosY = value;
            }
        }
    }
}
