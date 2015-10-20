using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 人员职责对应关系，具体到一类产品
    /// </summary>
    public class StaffDuty
    {
        /// <summary>
        /// 员工
        /// </summary>
        public Staff Staff { get; set; }

        /// <summary>
        /// 在该产品中的职责
        /// </summary>
        public Duty Duty { get; set; }
    }

    /// <summary>
    /// 职责
    /// </summary>
    public enum Duty
    {
        /// <summary>
        /// 硬件研发
        /// </summary>
        HARDWAREDEV,  
        /// <summary>
        /// 软件研发
        /// </summary>
        SOFTWAREDEV, 
        /// <summary>
        /// 产品负责人
        /// </summary>
        PM,           
        /// <summary>
        /// 生产
        /// </summary>
        MANUFACTURE,  
        /// <summary>
        /// 销售
        /// </summary>
        SALES,    
        /// <summary>
        /// 工程
        /// </summary>
        CONSTRUCT,  
        /// <summary>
        /// 市场
        /// </summary>
        MARKETING,  
        /// <summary>
        /// 质检
        /// </summary>
        QC
    }
}
