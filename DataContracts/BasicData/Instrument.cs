using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicData
{
    /// <summary>
    /// 系统
    /// </summary>
    public class Instrument
    {
        /// <summary>
        /// 系统唯一编号
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// 所属项目编号-用于索引所属项目并获取相关信息
        /// </summary>
        public int ProjectNumber { get; set; }

        /// <summary>
        /// 所属项目名称
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 施工安装位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 仪器类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 产品型号-备用
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 出厂时间
        /// </summary>
        public DateTime ProducedTime { get; set; }

        /// <summary>
        /// 在线状态
        /// </summary>
        public bool IsOnline { get; set; }

        /// <summary>
        /// 发货状态
        /// </summary>
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public List<StaffDuty> StaffDuties { get; set; }

        private DeviceStatus currentState = DeviceStatus.NORMAL;
        /// <summary>
        /// 仪器当前维修状态
        /// </summary>
        public DeviceStatus CurrentState
        {
            get { return currentState; }
            set
            {
                if (value == DeviceStatus.NORMAL)
                    CurrentFix = null;
            }
        }
        /// <summary>
        /// 当前维修事件，状态为正常则为null
        /// </summary>
        public Fix CurrentFix { get; set; }
    }

    /// <summary>
    /// 仪器状态枚举
    /// </summary>
    public enum DeviceStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        NORMAL,
        /// <summary>
        /// 待维修
        /// </summary>
        WAITFORFIX,
        /// <summary>
        /// 正在维修
        /// </summary>
        FIXING,
        /// <summary>
        /// 延时派遣
        /// </summary>
        DISPATCHDELAYED,
        /// <summary>
        /// 延时完成
        /// </summary>
        FINISHDELAYED
    }

    /// <summary>
    /// 发货状态
    /// </summary>
    public enum DeliveryStatus
    {
        /// <summary>
        /// 已完成生产
        /// </summary>
        PRODUCED,
        /// <summary>
        /// 正在生产
        /// </summary>
        PRODUCING,
    }
}
