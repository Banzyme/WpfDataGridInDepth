using PeculiaWPFDataGridInDepth.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth
{
    public class MainWindowViewModel
    {
        private List<TaxPayer> taxpayersList;

        public MainWindowViewModel()
        {
            LoadIntialData();  
        }


        public ObservableCollection<TaxPayer> TaxPayersList
        {
            get { return new ObservableCollection<TaxPayer>(taxpayersList); }
            set { taxpayersList = value.ToList(); }
        }


        private void LoadIntialData()
        {
            taxpayersList = DataService.GetAllTaxPayers();
        }
    }
}
