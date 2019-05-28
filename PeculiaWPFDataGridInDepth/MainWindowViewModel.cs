using PeculiaWPFDataGridInDepth.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PeculiaWPFDataGridInDepth
{
    public class MainWindowViewModel : BindableBase
    {
        private List<TaxPayer> taxpayersList;
        public ListCollectionView collectionView;
        public GENDER currentGenderFilter = GENDER.FEMALE;
        private string searchString = string.Empty;

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


        public GENDER GenderFilter
        {
            get { return currentGenderFilter; }
            set
            {
                FilterGridCollection(value);
                //MessageBox.Show($"Setting gender filter again:  {value}.");
                SetProperty(ref currentGenderFilter, value);
            }
        }

        public string SearchString
        {
            get
            {
                return searchString;
            }

            set
            {
                //MessageBox.Show($"New search term: {value}");
                FilterByFirstName(value);
                SetProperty(ref searchString, value);
            }

        }



        private void LoadIntialData()
        {
            taxpayersList = DataService.GetAllTaxPayers();
            collectionView = new ListCollectionView(taxpayersList);
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));
        }

        private void FilterByFirstName(string searchTerm)
        {
            if (collectionView == null) return;

            collectionView.Filter = (user) =>
            {
                TaxPayer payer = user as TaxPayer;

                if (payer.Firstname.Contains(searchTerm)) return true;

                return false;
            };
        }

        private void FilterGridCollection(GENDER filterVal)
        {
            if (collectionView != null)
            {
                collectionView.Filter = (user) =>
                {
                    TaxPayer payer = user as TaxPayer;

                    if (payer.Gender == filterVal)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
        }
    }
}
