/* Author: Jonathan Ochampaugh
 * Class Name: SelectionEventHandler.cs
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
    /// <summary>
    /// Class for Selection Event Handling
    /// </summary>
    public class SelectionEventHandler : EventArgs
    {
        /// <summary>
        /// IOrderItem item
        /// </summary>
        public IOrderItem item;
    }
}
