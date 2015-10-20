using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugContract
{
    public class Message
    {
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; protected set; }

        /// <summary>
        /// 该消息是否为仪器发送，用来区分消息来源
        /// </summary>
        public bool PullByDevice { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否已发送（不见得需要该字段）
        /// </summary>
        public bool Sent { get; set; }
    }

}
