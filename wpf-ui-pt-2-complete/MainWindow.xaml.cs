using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace in_class_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel _vm;

        public MainWindow()
        {
            _vm = new ViewModel()
            {
                Name = "Gui",
                Value = 50,
                Entries = new ObservableCollection<Entry>
                {
                    new Entry {Name = "Blorp", Value = 15}
                },
                Florp = new Florp { Flizoop = "Blap" }
            };
            DataContext = _vm;
            InitializeComponent();
        }

        private void AddToListButtonClick(object sender, RoutedEventArgs e)
        {
            _vm.Florp.Flizoop = "Blamp";
            _vm.Entries.Add(new Entry { Name = _vm.Name, Value = _vm.Value });
        }
    }
}
