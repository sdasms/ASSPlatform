using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    /// <summary>
    /// 产品
    /// </summary>
    public interface Products
    {
        string ProductType { get; set; }//产品类型
        string ProductModel { get; set; }//产品型号
        int ProductsNumber { get; set; }//产品数量
        string ProductsUnit { get; set; }//单位
        string ProductsResponsiblePerson { get; set; }//产品负责人
    }
}
