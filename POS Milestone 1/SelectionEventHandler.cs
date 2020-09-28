/* Author: Jonathan Ochampaugh
 * Class Name: ButtonOrderControlComponent.cs
 * Purpose: Switches between screens based on buttons clicked
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BleakwindBuffet.Data;

namespace POS_Milestone_1
{
    public class SelectionEventHandler : EventArgs
    {
        public IOrderItem item;
    }
}
