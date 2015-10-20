using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugContract
{
    /// <summary>
    /// 调试指令
    /// </summary>
    public class Command
    {
        /// <summary>
        /// 指令发送时间
        /// </summary>
        public DateTime SendTime { get; set; }
        
        /// <summary>
        /// 指令内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 指令类型，调试指令或答复信息
        /// </summary>
        public CommandType Type { get; set; }

        /// <summary>
        /// 指令类型枚举
        /// </summary>
        public enum CommandType
        {
            /// <summary>
            /// 调试指令
            /// </summary>
            COMMAND,
            /// <summary>
            /// 答复
            /// </summary>
            REPLY,
        }
    }
}
