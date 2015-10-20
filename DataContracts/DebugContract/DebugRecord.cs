using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicData;

namespace DebugContract
{
    /// <summary>
    /// 调试记录，每次连接生成一个记录
    /// </summary>
    public class DebugRecord
    {
        /// <summary>
        /// 指令历史
        /// </summary>
        public List<Command> CommandHistory { get; set; }

        /// <summary>
        /// 聊天历史
        /// </summary>
        public Chat Chat { get; set; }

        /// <summary>
        /// 维修结束后对问题和解决方法，完成状态的描述
        /// </summary>
        public FixRecord Description { get; set; }
    }
}
