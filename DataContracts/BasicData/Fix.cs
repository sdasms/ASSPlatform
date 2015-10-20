using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 维修事件
    /// </summary>
    public class Fix
    {
        /// <summary>
        /// 故障发生时间
        /// </summary>
        public DateTime FaultTime { get; set; }

        /// <summary>
        /// 故障原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 维修方案
        /// </summary>
        public string Plan { get; set; } 

        /// <summary>
        /// 派遣截止时间
        /// </summary>
        public DateTime DipatchDeadline { get; set; } 

        /// <summary>
        /// 维修截止时间
        /// </summary>
        public DateTime FinishDeadline { get; set; }  

        /// <summary>
        /// 延时维修
        /// </summary>
        public List<Delay> DispatchDelays { get; set; }
 
        /// <summary>
        /// 延时完成
        /// </summary>
        public List<Delay> FinishDelays { get; set; }
 
        /// <summary>
        /// 派遣任务
        /// </summary>
        public List<FixMission> Missions { get; set; }
    }

    /// <summary>
    /// 派遣维修任务
    /// </summary>
    public class FixMission
    {
        /// <summary>
        /// 派遣员工
        /// </summary>
        public Staff Dispatched { get; set; } 

        /// <summary>
        /// 派遣时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        public string Mission { get; set; }
    }
}
