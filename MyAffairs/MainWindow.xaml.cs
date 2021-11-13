using System;
using System.Collections.Generic;
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
using MyAffairs.MyFolder;
using MyAffairs.Services;

namespace MyAffairs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string PATH = $"{Environment.CurrentDirectory}\\AffairsDataList.json";
        private BindingList<AffairsModel> _MyData;
        private FileSaver _FileIO;
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _FileIO = new FileSaver(PATH);
            try
            {
                _MyData = _FileIO.LoadInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            dgMA.ItemsSource = _MyData;
            _MyData.ListChanged += _MyData_ListChanged;
        }

        private void _MyData_ListChanged(object sender, ListChangedEventArgs e)
        {

            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _FileIO.SaveInfo(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }

            //switch case analog
            /*   switch (e.ListChangedType)
               {
                   case ListChangedType.Reset:
                       break;
                   case ListChangedType.ItemAdded:
                       break;
                   case ListChangedType.ItemDeleted:
                       break;
                   case ListChangedType.ItemChanged:
                       break;
                   case ListChangedType.ItemMoved:
                       break;
                   case ListChangedType.PropertyDescriptorAdded:
                       break;
                   case ListChangedType.PropertyDescriptorChanged:
                       break;
                   case ListChangedType.PropertyDescriptorDeleted:
                       break;
               }*/
        }
    }
}
