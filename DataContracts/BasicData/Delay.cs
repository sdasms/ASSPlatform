using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 延时派遣或完成维修
    /// </summary>
    public class Delay
    {
        /// <summary>
        /// 事件等级（备用）
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 责任人（作出延时决定者）
        /// </summary>
        public Staff Responsible { get; set; }

        /// <summary>
        /// 作出决定的时间
        /// </summary>
        public DateTime DecisionTime { get; set; }

        /// <summary>
        /// 延时截止时间
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
    }
}
