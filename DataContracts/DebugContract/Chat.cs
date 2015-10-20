using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicData;

namespace DebugContract
{
    /// <summary>
    /// 聊天会话
    /// </summary>
    public class Chat
    {
        /// <summary>
        /// 远程调试人员
        /// </summary>
        public Staff RemoteDebugger { get; set; }

        /// <summary>
        /// 本地调试人员
        /// </summary>
        public Staff LocalDebugger { get; set; }

        /// <summary>
        /// 最近的消息队列
        /// </summary>
        public Queue<Message> RecentMessages { get; set; }
    }
}
