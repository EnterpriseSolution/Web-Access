using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum Exemption
    {
        [StringValue("101")]
        [DisplayText("一般征税")]
        A101,

        [StringValue("118")]
        [DisplayText("整车征税")]
        A118,

        [StringValue("119")]
        [DisplayText("零部件征税")]
        A119,

        [StringValue("201")]
        [DisplayText("无偿援助")]
        A201,

        [StringValue("299")]
        [DisplayText("其他法定   ")]
        A299,

        [StringValue("301")]
        [DisplayText("特定区域")]
        A301,

        [StringValue("307")]
        [DisplayText("保税区")]
        A307,

        [StringValue("399")]
        [DisplayText("其他地区")]
        A399,

        [StringValue("401")]
        [DisplayText("科教用品")]
        A401,

        [StringValue("403")]
        [DisplayText("技术改造")]
        A403,

        [StringValue("406")]
        [DisplayText("重大项目")]
        A406,

        [StringValue("412")]
        [DisplayText("基础设施")]
        A412,

        [StringValue("413")]
        [DisplayText("残疾人")]
        A413,

        [StringValue("417")]
        [DisplayText("远洋渔业")]
        A417,
        
        [StringValue("418")]
        [DisplayText("国产化")]
        A418,

        [StringValue("419")]
        [DisplayText("整车特征")]
        A419,
        
        [StringValue("420")]
        [DisplayText("远洋船舶")]
        A420,
        
        [StringValue("421")]
        [DisplayText("内销设备")]
        A421,

        [StringValue("422")]
        [DisplayText("集成电路")]
        A422,

        [StringValue("423")]
        [DisplayText("膜晶显")]
        A423,
        
        [StringValue("499")]
        [DisplayText("ITA产品")]
        A499,

        [StringValue("501")]
        [DisplayText("加工设备")]
        A501,

        [StringValue("502")]
        [DisplayText("来料加工")]
        A502,

        [StringValue("503")]
        [DisplayText("进料加工")]
        A503,

        [StringValue("506")]
        [DisplayText("边境小额")]
        A506,

        [StringValue("510")]
        [DisplayText("港澳OPA")]
        A510,
        
        [StringValue("601")]
        [DisplayText("中外合资")]
        A601,
        
        [StringValue("602")]
        [DisplayText("中外合作")]
        A602,
        
        [StringValue("603")]
        [DisplayText("外资企业")]
        A603,

        [StringValue("605")]
        [DisplayText("勘探开发煤气层")]
        A605,
        
        [StringValue("606")]
        [DisplayText("海洋石油")]
        A606,

        [StringValue("605")]
        [DisplayText("陆上石油")]
        A608,

        [StringValue("609")]
        [DisplayText("货款项目")]
        A609,

        [StringValue("611")]
        [DisplayText("货款中标")]
        A611,
        
        [StringValue("789")]
        [DisplayText("鼓励项目")]
        A789,

        [StringValue("799")]
        [DisplayText("自有资金")]
        A799,

        [StringValue("801")]
        [DisplayText("救灾捐赠")]
        A801,

        [StringValue("802")]
        [DisplayText("扶贫慈善")]
        A802,

        [StringValue("888")]
        [DisplayText("航材减免")]
        A888,

        [StringValue("997")]
        [DisplayText("自贸协定")]
        A997,

        [StringValue("998")]
        [DisplayText("内部暂定")]
        A998,

        [StringValue("999")]
        [DisplayText("例外减免")]
        A999
    }
}
