using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 维修记录
    /// </summary>
    public class FixRecord
    {
        /// <summary>
        /// 故障原因
        /// </summary>
        public string FaultReason { get; set; }  

        /// <summary>
        /// 维修方案
        /// </summary>
        public string MaintenancePlan { get; set; }  

        /// <summary>
        /// 故障时间
        /// </summary>
        public DateTime FaultTime { get; set; }  

        /// <summary>
        /// 最新状态发生时间
        /// </summary>
        public DateTime RecentStatusTime { get; set; }  

        /// <summary>
        /// 仪器UID
        /// </summary>
        public Guid InstrumentUID { get; set; }  

        /// <summary>
        /// 仪器类型
        /// </summary>
        public string InstrumentType { get; set; } 

        /// <summary>
        /// 重要事件及时间节点
        /// </summary>
        public Dictionary<DateTime, DeviceStatus> MileStones { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime AccomplishedTime { get; set; }

        /// <summary>
        /// 是否已审核
        /// </summary>
        public bool Auditted { get; set; }

        /// <summary>
        /// 审核者
        /// </summary>
        public Staff Auditor { get; set; }
    }
}
