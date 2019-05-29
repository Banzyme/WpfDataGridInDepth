using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public class Person
    {
        private int id;
        private string firstname;
        private string lastname;
        private string birthPlace;
        private GENDER gender;
        private Address adress;
        private List<Order> _orders;

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public GENDER Gender { get => gender; set => gender = value; }
        public Address Adress { get => adress; set => adress = value; }
        public string BirthPlace { get => birthPlace; set => birthPlace = value; }
        public List<Order> Orders { get => _orders; set => _orders = value; }
    }


    public enum GENDER
    {
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
