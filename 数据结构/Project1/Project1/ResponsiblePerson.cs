using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 项目负责人
    /// </summary>
    public interface ResponsiblePerson
    {
        string ResponsiblePersonName { get; set; }//负责人名称
        int ResponsiblePersonPhoneNumber { get; set; }//负责人电话
        string ResponsiblePersonEmail { get; set; }//负责人邮箱
    }
}
