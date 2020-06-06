using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMH.crmService.Data;

namespace XMH.crmService
{
    public class test
    {
        public void DoAction()
        {
            Receivable_Acc acc = new Receivable_Acc();

            //acc.SetDelete();        //删除公客/私客回收站里的客户，彻底从数据库中删除
            //acc.SetMoveCustomer();  //转移所有客户

            //acc.SetCustomer_protect();      //保护的客户,申保的客户type=1
            //acc.SetCustomer_CreateDate();   //创建时间在期间的 type=2
            //acc.SetYeJiMove();              //业绩达标的type=3
            //acc.SetYingShou();              //应收款项》0的 type=4
            //acc.SetCustomer_Employee();     //不转的客户的客户 type=5
            //按客服分组转移客户
            acc.SetDoAction();
        }

        public void DoActionTest()
        {
            string strFileName = AppDomain.CurrentDomain.BaseDirectory;

            imsNodeFeatService ss = new imsNodeFeatService();
        }
    }
}