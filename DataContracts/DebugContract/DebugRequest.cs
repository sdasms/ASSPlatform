using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicData;

namespace DebugContract
{
    public class DebugRequest
    {
        /// <summary>
        /// 远程调试者(发起请求方)
        /// </summary>
        public Staff RemoteDebugger { get; set; }

        /// <summary>
        /// 仪器UID
        /// </summary>
        public Guid DeviceUID { get; set; }

        /// <summary>
        /// 发起请求时间
        /// </summary>
        public DateTime RequestTime { get; set; }

        /// <summary>
        /// 客户是否同意该请求
        /// </summary>
        public bool Agreed { get; set; }
    }
}
