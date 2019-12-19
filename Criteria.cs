using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests.ModelsGUI
{
    public class Criteria
    {
        public int Ball { get; set; }
        public string Status { get; set; }
        public string StatusInfo { get; set; }

        public Criteria(int ball, string status, string statusInfo)
        {
            Ball = ball;
            Status = status;
            StatusInfo = StatusInfo;
        }
    }
}
