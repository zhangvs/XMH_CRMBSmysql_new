using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Common
{
    public enum QuestionStatus
    {
        //0.待处理、1.处理中、2.待确认、3.待评价、4.已完成
      
        待处理 = 0,
        处理中 = 1,
        待确认 = 2,
        待评价 = 3,
        已完成 = 4,
        全部 = -1
    };
}
