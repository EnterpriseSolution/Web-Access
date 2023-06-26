using jQueryApi;
using jQueryApi.UI.Widgets;
using System;
using System.Collections.Generic;
using System.Html;

namespace Serenity
{
    public class FilterDialog : TemplatedDialog
    {
        private FilterPanel filterPanel;

        public FilterDialog()
        {
            filterPanel = new FilterPanel(this.ById("FilterPanel"));
            filterPanel.ShowInitialLine = true;
            filterPanel.ShowSearchButton = false;
            filterPanel.UpdateStoreOnReset = false;
        }

        protected override string GetTemplate()
        {
            return "<div id='~_FilterPanel'/>";
        }

        protected override DialogOptions GetDialogOptions()
        {
            var opt = base.GetDialogOptions();
            opt.Buttons = new[] 
            {
                new DialogButton {
                    Text = "OK",
                    Click = delegate
                    {
                        filterPanel.Search();
                        if (filterPanel.HasErrors)
                        {
                            Q.NotifyError("Please fix errors that are marked in red");
                            return;
                        }
                        DialogClose();
                    }
                },
                new DialogButton {
                    Text = "Cancel",
                    Click = DialogClose
                }
            };
            opt.Title = "Edit Filter";

            return opt;
        }

        public FilterPanel FilterPanel
        {
            get { return filterPanel; }
        }
    }
}