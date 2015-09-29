using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 销售人员
    /// </summary>
    public interface SalesManagers
    {
        string SalesName { get; set; }//销售名称
        int SalesPhoneNumber { get; set; }//销售电话
        string SalesEmail { get; set; }//销售邮箱
    }
}
