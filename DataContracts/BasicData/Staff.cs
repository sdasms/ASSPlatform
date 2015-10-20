using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 通讯录
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        public int UID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public Department Department { get; set; }
    }

    public enum Department
    { 
        /// <summary>
        /// 销售部
        /// </summary>
        SALES,
        /// <summary>
        /// 生产部
        /// </summary>
        MANIFACTURE,
        /// <summary>
        /// 技术部
        /// </summary>
        TECH,
        /// <summary>
        /// 工程部
        /// </summary>
        CONSTRUCT,
        /// <summary>
        /// 市场部
        /// </summary>
        MARKETING,
        /// <summary>
        /// 质检部
        /// </summary>
        QC
    }
}
