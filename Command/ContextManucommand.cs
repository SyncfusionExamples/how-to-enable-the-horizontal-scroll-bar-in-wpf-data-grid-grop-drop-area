using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestingSample
{
    public static class ContextMenucommand
    {

        #region SortAscending
        static BaseCommand sortAscending;
        public static BaseCommand SortAscending
        {
            get
            {
                if (sortAscending == null)
                    sortAscending = new BaseCommand(OnSortAscendingClicked, CanSortAscending);

                return sortAscending;
            }
        }


        private static void OnSortAscendingClicked(object obj)
        {
            if (obj is GridColumnContextMenuInfo)
            {
                var grid = (obj as GridContextMenuInfo).DataGrid;
                var column = (obj as GridColumnContextMenuInfo).Column;
                grid.SortColumnDescriptions.Clear();
                grid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = column.MappingName, SortDirection = ListSortDirection.Ascending });
            }
        }

        private static bool CanSortAscending(object obj)
        {
            if (obj is GridColumnContextMenuInfo)
            {
                var grid = (obj as GridContextMenuInfo).DataGrid;
                var column = (obj as GridColumnContextMenuInfo).Column;
                var sortColumn = grid.SortColumnDescriptions.FirstOrDefault(x => x.ColumnName == column.MappingName);
                if (sortColumn != null)
                {
                    if ((sortColumn as SortColumnDescription).SortDirection == ListSortDirection.Ascending)
                        return false;
                }
                return grid.AllowSorting;
            }
            return false;
        }
        #endregion
    }
}
