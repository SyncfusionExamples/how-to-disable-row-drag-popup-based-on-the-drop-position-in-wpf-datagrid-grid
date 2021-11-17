# How to disable row drag popup based on the drop position in WPF TreeGrid(SfTreeGrid)?

## About the sample

This sample illustrates how to disable row drag popup based on the drop position in WPF TreeGrid(SfTreeGrid).

[WPF TreeGrid](https://www.syncfusion.com/wpf-controls/treegrid) (SfTreeGrid), will display a popup while dragging the rows in which the drop status and the dragging rows count will be displayed. You can disable this popup based on some condition by using [TreeGrid.RowDragDropController.DragOver](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.TreeGridRowDragDropController.html#Syncfusion_UI_Xaml_TreeGrid_TreeGridRowDragDropController_DragOver) event.

```C#
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

```

KB article - [How to disable row drag popup based on the drop position in WPF TreeGrid(SfTreeGrid)?](https://www.syncfusion.com/kb/12506/how-to-disable-row-drag-popup-based-on-the-drop-position-in-wpf-treegridsftreegrid)

## Requirements to run the demo

Visual Studio 2015 and above versions

