using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToddCorp.GlobalInterfaces
{
    public interface IConvert
    {
        bool RoofIsDown { get; set; }
        string Convert();
    }
}
