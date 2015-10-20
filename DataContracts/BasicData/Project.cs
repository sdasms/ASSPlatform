using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 项目
    /// </summary>
    public class Project
    {

        /// <summary>
        /// 项目编号-唯一
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 项目地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 销售经理
        /// </summary>
        public Staff SalesManager { get; set; }

        /// <summary>
        /// 工程负责人
        /// </summary>
        public Staff ProjectManager { get; set; }

        /// <summary>
        /// 项目备注
        /// </summary>
        public string Remarks { get; set; } 

        /// <summary>
        /// 要求交货时间
        /// </summary>
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// 系统集合
        /// </summary>
        public List<Instrument> Instruments { get; set; }
    }
}
