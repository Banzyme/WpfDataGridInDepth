using PeculiaWPFDataGridInDepth.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PeculiaWPFDataGridInDepth
{
    public class MainWindowViewModel
    {
        private List<TaxPayer> taxpayersList;
        public ListCollectionView collectionView;
        public GENDER currentGenderFilter = GENDER.FEMALE;

        public MainWindowViewModel()
        {
            LoadIntialData();
        }


        public ObservableCollection<TaxPayer> TaxPayersList
        {
            get { return new ObservableCollection<TaxPayer>(taxpayersList); }
            set { taxpayersList = value.ToList(); }
        }

        public ListCollectionView TaxpayersCollection
        {
            get
            {
                return collectionView;
            }
            set
            {
                collectionView = value;
            }

        }


        public GENDER GenderFilter { get { return currentGenderFilter; } set { } }



        private void LoadIntialData()
        {
            taxpayersList = DataService.GetAllTaxPayers();
            collectionView = new ListCollectionView(taxpayersList);
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));
        }
    }
}
