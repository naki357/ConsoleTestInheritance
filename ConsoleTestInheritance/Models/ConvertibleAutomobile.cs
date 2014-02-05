using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToddCorp.GlobalInterfaces;

namespace ConsoleTestInheritance.Models
{
    internal class ConvertibleAutomobile : Automobile, IConvert
    {
        #region Properties 
        public bool RoofIsDown { get; set; }
        #endregion

        internal ConvertibleAutomobile(string name) : base(name) { }

        public string Convert()
        {
            if (RoofIsDown)
                RoofIsDown = false;
            else
                RoofIsDown = true;

            return "Done converting automobile.";
        }
    }
}
