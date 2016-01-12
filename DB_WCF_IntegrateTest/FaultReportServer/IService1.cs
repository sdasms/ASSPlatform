using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace FaultReportServer
{
    [ServiceContract]
    public interface IFaultReportContract
    {
        /// <summary>
        /// 仪器自动上传错误
        /// </summary>
        /// <param name="FaultUID"></param>
        /// <param name="InstrumentUID"></param>
        /// <param name="FaultCode"></param>
        /// <param name="FaultDetail"></param>
        /// <param name="FaultTime"></param>
        /// <returns>新建的维修事件ID</returns>
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        int AutoFaultReport(string InstrumentUID, string FaultCode, string FaultDetail, DateTime FaultTime);

        /// <summary>
        /// 发送附件
        /// </summary>
        /// <param name="FixEventID">对应的维修事件</param>
        /// <param name="AttachedFile">附件</param>
        [OperationContract]
        void SendAttachedFile(string InstrumentID, int FixEventID, byte[] AttachedFile);

        [OperationContract]
        bool ManualFaultReport(CustomerReport Report);

        //该指令用于现场服务器和向中心服务器通报仪器状态，定时发送；仪器与现场服务器之间通过心跳信号同步在线状态，超时不通报的视为掉线
        [OperationContract]
        void TellNetStatus(string InstrumentUID, bool IsOnline);
    }


    [DataContract]
    public class CustomerReport
    {
        [DataMember]
        public string ProjectID { get; set; }

        [DataMember]
        public string ProjectName { get; set; }

        [DataMember]
        public DateTime ReportTime { get; set; }

        [DataMember]
        public string Descripton { get; set; }
    }
}
