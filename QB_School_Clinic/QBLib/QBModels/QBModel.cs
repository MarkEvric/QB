using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QBLib.Models
{
    public class QBModel
    {

        
        public class QBDisplay
        {
            public int QBId { get; set; }
            public string QBName { get; set; }
            public string QBGradeYearLevel { get; set; }
            public string QBReasonForAdmission { get; set; }
            public string QBDate { get; set; }
            public string QBTime { get; set; }
            public string Search { get; set; }
        }
    }
}

