using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTARGET
{
    class phnEvent
    {
        public byte Be { get; set; }
        public byte Bia { get; set; }

        public byte Diem { get; set; }

        public phnEvent(byte _be, byte _bia, byte _diem)
        {
            this.Be = _be;
            this.Bia = _bia;
            this.Diem = _diem;
        }

    }
}
