using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Rocketin.Model
{
    public class BaseResponseModel<T>
    {
        public bool Status { get; set; }
        public string Code { get; set; }
        public string Messages { get; set; }
        public T Data { set; get; }
    }

    public class BaseResponseModel
    {
        public bool Status { get; set; }
        public string Code { get; set; }
        public string Messages { get; set; }
        public int ID { get; set; }
    }
}
