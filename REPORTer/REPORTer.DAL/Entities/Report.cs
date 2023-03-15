
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.DAL.Entities
{
    public class Report : BaseEntity
    {
        public int UserID { get; set; }
        public bool IsReported { get; set; }    
        public string Content { get; set; }
        public DateTime CreatinDate { get; set; }
    }
}
