using PeculiaWPFDataGridInDepth.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PeculiaWPFDataGridInDepth
{
    public class MainWindowViewModel : BindableBase
    {
        private List<Person> taxpayersList;
        public ListCollectionView collectionView;
        public GENDER currentGenderFilter = GENDER.FEMALE;
        private string searchString = string.Empty;

        public MainWindowViewModel()
        {
            LoadIntialData();
        }

        public RelayCommand<object> SpellCheckCommand { get; private set; }
        public RelayCommand<object> GroupByCommand {get;private set;}

    public ObservableCollection<Person> TaxPayersList
        {
            get { return new ObservableCollection<Person>(taxpayersList); }
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
            taxpayersList = DataService.GetAllclients();
            collectionView = new ListCollectionView(taxpayersList);
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));
            SpellCheckCommand = new RelayCommand<object>(OnCheckSpelling);
            GroupByCommand = new RelayCommand<object>(OnGroupByAction);
        }

        private void OnGroupByAction(object groupingProperty)
        {
            var groupby = (string)groupingProperty;

            switch (groupby)
            {
                case "BirthPlace":
                    collectionView.GroupDescriptions.Clear();
                    collectionView.GroupDescriptions.Add(new PropertyGroupDescription("BirthPlace"));
                    break;
                case "Gender":
                default:
                    collectionView.GroupDescriptions.Clear();
                    collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));
                    break;
            }
        }

        private void OnCheckSpelling(object txtBx)
        {
            var textBox = (TextBox)txtBx;
            int noOfErrors = 0;
            string[] contentList = textBox.Text.Split(' ');

            contentList.ToList().ForEach( word => {

                var phrase = new TextBox() { Text = word };
                phrase.SpellCheck.IsEnabled = true;

                SpellingError err = phrase.GetSpellingError(0) ;
                var errLength = phrase.GetSpellingErrorLength(0);
                var errStart = phrase.GetSpellingErrorStart(0);

                if (err != null) noOfErrors++;
            });

            MessageBox.Show($"You have {noOfErrors} spelling error(s), please rectify then press procceed.");
        }

        private void FilterByFirstName(string searchTerm)
        {
            if (collectionView == null) return;

            collectionView.Filter = (user) =>
            {
                Person payer = user as Person;

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
                    Person payer = user as Person;

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
