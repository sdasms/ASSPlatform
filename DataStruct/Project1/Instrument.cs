using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 系统
    /// </summary>
    public class Instrument
    {
        string UID { get; set; }//唯一识别编号
        string ProjectNumber { get; set; }//所属项目编号-用于索引所属项目并获取相关信息
        string ProjectName { get; set; }//所属项目名称
        string Location { get; set; }//安装位置
        string Type { get; set; }//仪器类型  DTS  气体
        State State { get; set; }//仪器状态-维修状态
        string Model { get; set; }//产品型号-备用
        string Remarks { get; set; }//备注
        bool Online { get; set; }//在线状态
        string DeliveryStatus;//发货状态
        DateTime FactoryTime;//出厂时间
        DateTime FaultTime;//故障发生时间
        int CuePeriod;//下次提示推送周期
        DateTime DelayTime;//延期到期时间
        public List<DutyContactPair> Dutycontactpair;//联系人
    }

    public enum State
    {
        //故障
        //正在维修
        //正常
    }

    /// <summary>
    /// 联系人
    /// </summary>
    public class DutyContactPair
    {
        public Contact Contact { get; set; }
        public Duty Duty { get; set; }
    }

    /// <summary>
    /// 联系人类型
    /// </summary>
    public enum Duty
    {
        //硬件负责人
        //软件
        //系统负责人
        //销售和工程在项目里-系统发生问题时如何推送给销售和工程
    }
}
