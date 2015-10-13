using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 项目
    /// </summary>
    public class Project
    {
        string ProjectNumber { get; set; }//项目编号-唯一
        string ProjectName { get; set; }//项目名称
        string CustomerName { get; set; }//客户名称
        string ProjectSddress { get; set; }//项目地址
        Contact SalesManager { get; set; }//销售经理
        Contact ProjectManager { get; set; }//工程负责人
        string ContactPersonName { get; set; }//联系人姓名
        int ContactPersonPhoneNumber { get; set; }//联系人电话
        string Remarks { get; set; }//项目备注
        string ProjectState { get; set; }//项目状态：正常、维修
        DateTime DeliveryTime { get; set; }//要求交货时间
        List<Instrument> Instrument { get; set; }//系统集合

        List<Record> Record;//维修记录;


    }
}
