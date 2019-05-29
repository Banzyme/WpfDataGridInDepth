using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public class Order
    {
        private int id;
        private ORDER_STATUS status;
        private string orderDescription;
        private DateTime dateStarted = DateTime.MinValue;


        public int Id { get => id; set => id = value; }
        public ORDER_STATUS Status { get => status; set => status = value; }
        public DateTime DateStarted { get => dateStarted; set => dateStarted = value; }
        public string OrderDescription { get => orderDescription; set => orderDescription = value; }
    }


    public enum ORDER_STATUS
    {
        CREATED = 1 ,
        IN_PROGRESS,
        COMPLETED
    }
}
