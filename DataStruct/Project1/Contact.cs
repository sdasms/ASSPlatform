using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 通讯录
    /// </summary>
    public class Contact
    {
        int UID { get; set; } //用于索引
        string Name { get; set; }//姓名
        int PhoneNumber { get; set; }//电话
        string Email { get; set; }//邮箱
        Department Department { get; set; }//联系人类型:销售、产品、项目
    }

    public enum Department
    { 
        SALES,
        MANIFACTURE,
        TECH,
        ENGINEERING
    }
}
