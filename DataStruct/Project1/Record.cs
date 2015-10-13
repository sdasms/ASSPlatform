using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 维修记录
    /// </summary>
    class Record
    {
        string RecordNumber;//编号-自增列加快索引速度
        string TaskContent;//任务内容
        string FaultCause;//故障原因
        string MaintenancePlan;//维修方案
        DateTime FaultTime;//故障时间
        string InstrumentUID;//所属系统索引
        string InstrumentType;//仪器类型
        string MaintenanceState;//维修状态-故障、正在维修    
        string Repairpersonnel;//维修人员 集合  参与备注
        //派遣时间
        //完成时间

        public List<EventNode> EventNode;//节点小计事件-时间
        public class EventNode
        {
             //时间
            //完成情况
        }
    }
}
