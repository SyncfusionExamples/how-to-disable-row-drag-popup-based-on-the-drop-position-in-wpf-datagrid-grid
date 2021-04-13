using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfTreeGrid_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            treeGrid.RowDragDropController.DragOver += OnRowDragDropController_DragOver;
        }

        private void OnRowDragDropController_DragOver(object sender, TreeGridRowDragOverEventArgs e)
        {
            if (e.DropPosition == Syncfusion.UI.Xaml.TreeGrid.DropPosition.DropAbove)
            {
                e.ShowDragUI = true;
            }
            else
            {
                e.ShowDragUI = false;
                var popup = (Popup)this.treeGrid.RowDragDropController.GetType().GetField("dragpopup", System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance).GetValue(this.treeGrid.RowDragDropController);
                popup.IsOpen = false;
            }
        }
    }
}

