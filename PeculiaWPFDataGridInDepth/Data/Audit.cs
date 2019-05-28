using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public class Audit
    {
        private int id;
        private AuditStatus status;
        private string auditReason;
        private DateTime dateStarted = DateTime.MinValue;


        public int Id { get => id; set => id = value; }
        public string AuditReason { get => auditReason; set => auditReason = value; }
        public AuditStatus Status { get => status; set => status = value; }
        public DateTime DateStarted { get => dateStarted; set => dateStarted = value; }

    }


    public enum AuditStatus
    {
        OPENED = 1 ,
        IN_PROGRESS,
        COMPLETED
    }
}
