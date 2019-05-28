using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public static class DataService
    {
        private static List<TaxPayer> taxPayers = new List<TaxPayer>();

        public static List<TaxPayer> GetAllTaxPayers()
        {
            var audits1 = new List<Audit>()
            {
                new Audit(){Id=1 , Status = AuditStatus.OPENED, AuditReason ="Return not completed" },
                new Audit(){Id=2 , Status = AuditStatus.IN_PROGRESS, AuditReason ="Supporting docs outstanding" },
                new Audit(){Id=3 , Status = AuditStatus.COMPLETED, AuditReason ="Potential fraud" }
            };
            taxPayers.Add(new TaxPayer()
            {
                Id = 1,
                Firstname = "Mike",
                Lastname = "Start",
                Gender = GENDER.MALE,
                TaxRef = 1,
                AuditCases = audits1,
                Adress = new Address() { Place="Montana", StreeNo=810}
            });


            return taxPayers;
        }


    }
}
