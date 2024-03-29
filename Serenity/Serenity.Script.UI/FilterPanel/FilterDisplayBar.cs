﻿using jQueryApi;
using System;

namespace Serenity
{
    public class FilterDisplayBar : FilterWidgetBase<object>
    {
        public FilterDisplayBar(jQueryObject div)
            : base(div, null)
        {
            this.Element.Find(".cap").Text("Active Filter:");
            this.Element.Find(".edit").Text("edit filter");
            this.Element.Find(".reset").Attribute("title", "clear filter");

            jQueryEventHandler openFilterDialog = delegate(jQueryEvent e)
            {
                e.PreventDefault();
                var dialog = new FilterDialog();
                dialog.FilterPanel.Store = this.Store;
                dialog.DialogOpen();
            };

            this.Element.Find(".edit").Click(openFilterDialog);
            this.Element.Find(".txt").Click(openFilterDialog);

            this.Element.Find(".reset").Click(e =>
            {
                e.PreventDefault();
                this.Store.Items.Clear();
                this.Store.RaiseChanged();
            });
        }

        protected override void FilterStoreChanged()
        {
            base.FilterStoreChanged();

            var displayText = Store.DisplayText.TrimToNull();
            this.Element.Find(".current").Toggle(displayText != null);
            this.Element.Find(".reset").Toggle(displayText != null);
            this.Element.Find(".txt").Text("[" + (displayText ?? "none") + "]");
        }

        protected override string GetTemplate()
        {
            return 
                "<div>" + 
                    "<a class='reset'></a>" +
                    "<a class='edit'></a>" + 
                    "<div class='current'>" + 
                        "<span class='cap'></span>" +
                        "<a class='txt'></a>" + 
                    "</div>" + 
                "</div>";
        }
    }
}