using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace HRcalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Items1 = new ObservableCollection<DataGridViewModel>(DataSource.Items1);
            Items2 = new ObservableCollection<DataGridViewModel>(DataSource.Items2);
            Items3 = new ObservableCollection<DataGridViewModel>(DataSource.Items3);
            foreach (var item in Items1)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }
            foreach (var item in Items2)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }
            foreach (var item in Items3)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }
            Items1.CollectionChanged += Items1_CollectionChanged;
            Items2.CollectionChanged += Items2_CollectionChanged;
            Items3.CollectionChanged += Items3_CollectionChanged;

        }
        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TotalPoints1 = DataSource.maxPointsItems1 - CalculateTotalPoints(Items1);
            TotalPoints2 = DataSource.maxPointsItems2 - CalculateTotalPoints(Items2);
            TotalPoints3 = CalculateTotalPoints(Items3);
        }

        private void Items1_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DataGridViewModel item in e.NewItems)
                {
                    item.PropertyChanged += Item_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (DataGridViewModel item in e.OldItems)
                {
                    item.PropertyChanged -= Item_PropertyChanged;
                }
            }

            TotalPoints1 = CalculateTotalPoints(Items1);
        }

        private void Items2_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DataGridViewModel item in e.NewItems)
                {
                    item.PropertyChanged += Item_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (DataGridViewModel item in e.OldItems)
                {
                    item.PropertyChanged -= Item_PropertyChanged;
                }
            }

            TotalPoints2 = CalculateTotalPoints(Items2);
        }

        private void Items3_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DataGridViewModel item in e.NewItems)
                {
                    item.PropertyChanged += Item_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (DataGridViewModel item in e.OldItems)
                {
                    item.PropertyChanged -= Item_PropertyChanged;
                }
            }

            TotalPoints3 = CalculateTotalPoints(Items3);
        }

        private int _totalPoints1 = DataSource.maxPointsItems1;
        public int TotalPoints1
        {
            get => _totalPoints1;
            set
            {
                _totalPoints1 = value;
                OnPropertyChanged(nameof(TotalPoints1));
            }
        }

        private int _totalPoints2 = DataSource.maxPointsItems2;
        public int TotalPoints2
        {
            get => _totalPoints2;
            set
            {
                _totalPoints2 = value;
                OnPropertyChanged(nameof(TotalPoints2));
            }
        }

        private int _totalPoints3 = DataSource.maxPointsItems3;
        public int TotalPoints3
        {
            get => _totalPoints3;
            set
            {
                _totalPoints3 = value;
                OnPropertyChanged(nameof(TotalPoints3));
            }
        }

        private int CalculateTotalPoints(ObservableCollection<DataGridViewModel> curItem)
        {
            return curItem.Where(item => item.IsSelected).Sum(item => item.Points);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DataGrid_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (sender is DataGrid dataGrid)
            {
                // Перенаправляем событие к родительскому ScrollViewer
                mainScrollViewer.ScrollToVerticalOffset(mainScrollViewer.VerticalOffset - e.Delta);
                e.Handled = true;
            }
        }

        private void ClearItems1_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Items1)
            {
                item.IsSelected = false;
            }
            TotalPoints1 = DataSource.maxPointsItems1;
        }

        private void ClearItems2_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Items2)
            {
                item.IsSelected = false;
            }
            TotalPoints2 = DataSource.maxPointsItems2;
        }

        private void ClearItems3_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Items3)
            {
                item.IsSelected = false;
            }
            TotalPoints3 = DataSource.maxPointsItems3;
        }

        private void clearItemsAll_Click(object sender, RoutedEventArgs e)
        {
            ClearItems1_Click(sender, e);
            ClearItems2_Click(sender, e);
            ClearItems3_Click(sender, e);
        }
        public ObservableCollection<DataGridViewModel> Items1 { get; }
        public ObservableCollection<DataGridViewModel> Items2 { get; }
        public ObservableCollection<DataGridViewModel> Items3 { get; }
    }
}
