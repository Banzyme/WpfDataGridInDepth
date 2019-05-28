using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public class TaxPayer
    {
        private int id;
        private string firstname;
        private string lastname;
        private long taxRef;
        private GENDER gender;
        private Address adress;
        private List<Audit> auditCases;

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public long TaxRef { get => taxRef; set => taxRef = value; }
        public List<Audit> AuditCases { get => auditCases; set => auditCases = value; }
        public GENDER Gender { get => gender; set => gender = value; }
        public Address Adress { get => adress; set => adress = value; }
    }


    public enum GENDER{
        MALE = 1,
        FEMALE
    }

    public class Address
    {
        public string Place { get; set; }
        public int StreeNo { get; set; }

        public override string ToString()
        {
            return $"Address: {Place}, {StreeNo}";
        }
    }
}
