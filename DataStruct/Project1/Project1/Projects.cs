using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 项目
    /// </summary>
    public interface Projects:Products,SalesManagers,ResponsiblePerson
    {
        string ProjectNumber { get; set; }//项目编号
        string ProjectName { get; set; }//项目名称
        string CustomerName { get; set; }//客户名称
        string ProjectSddress { get; set; }//项目地址
        string SalesManager { get; set; }//销售经理
        string ContactPersonName { get; set; }//联系人姓名
        int ContactPersonPhoneNumber { get; set; }//联系人电话
        string Remarks { get; set; }//项目备注
        DateTime DeliveryTime { get; set; }//要求交货时间
        Products[] products { get; set; }//产品集合
        SalesManagers[] salesmanagers { get; set; }//销售经理集合
        ResponsiblePerson[] responsibleperson { get; set; }//项目负责人集合

    }
}
