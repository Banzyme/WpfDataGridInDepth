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


            var audits2 = new List<Audit>()
            {
                new Audit(){Id=1 , Status = AuditStatus.OPENED, AuditReason ="Return not completed" },
                new Audit(){Id=2 , Status = AuditStatus.IN_PROGRESS, AuditReason ="Supporting docs outstanding" },
                new Audit(){Id=3 , Status = AuditStatus.COMPLETED, AuditReason ="Potential fraud" }
            };
            taxPayers.Add(new TaxPayer()
            {
                Id = 1,
                Firstname = "Sahron",
                Lastname = "Meyer",
                Gender = GENDER.FEMALE,
                TaxRef = 1,
                AuditCases = audits2,
                Adress = new Address() { Place = "Hatfield", StreeNo = 810 }
            });


            var audits3 = new List<Audit>()
            {
                new Audit(){Id=1 , Status = AuditStatus.OPENED, AuditReason ="Return not completed" },
                new Audit(){Id=2 , Status = AuditStatus.IN_PROGRESS, AuditReason ="Supporting docs outstanding" },
                new Audit(){Id=3 , Status = AuditStatus.COMPLETED, AuditReason ="Potential fraud" }
            };
            taxPayers.Add(new TaxPayer()
            {
                Id = 1,
                Firstname = "ENDEE",
                Lastname = "Sa",
                Gender = GENDER.FEMALE,
                TaxRef = 1,
                AuditCases = audits3,
                Adress = new Address() { Place = "New york", StreeNo = 810 }
            });






            return taxPayers;
        }


    }
}
