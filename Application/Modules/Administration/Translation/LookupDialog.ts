
namespace Matrix.Administration {
  
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.resizable()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.maximizable()
    export class LookupDialog extends Serenity.TemplatedDialog<any> {
        LookupName: string;
        LookupFilter: string;
        CurrentPageIndex: number;
        TargetId:string;
        vuejs: any;
                 
        KeyValue1: string;
        KeyValue2: string;
        KeyValue3: string;
          
        constructor(data: any) {
            super(data);

            this.LookupName = data.LookupName;
            this.LookupFilter = data.LookupFilter;
            this.CurrentPageIndex = data.CurrentPageIndex;
            this.TargetId = data.TargetId;

            this.KeyValue1 = "";
            this.KeyValue2 = "";
            this.KeyValue3 = "";
        }
        

        protected onDialogOpen() {
            super.onDialogOpen();

            //$(this).dialog('widget').position({ my: "center", at: "center", of: window });

            var data = {
                LookupName: this.LookupName,
                LookupFilter: this.LookupFilter,
                CurrentPageIndex: this.CurrentPageIndex
            };

            Matrix.Administration.TranslationService.Lookup(data,
                response => {
                    console.log("GetData response:", response);
                    this.InitializeDialog(response);
                    this.InitializeVueJS(this,response, this.LookupName, this.LookupFilter, this.CurrentPageIndex);
                });

        }

        private InitializeDialog(response: any) {
            this.dialogTitle = response.Description;
        }


        private InitializeVueJS(parent:any,response: any,lookupName: string, lookupFilter: string, currentPageIndex: number): void {
            this.vuejs = new Vue({
                el: '#lookup',
                data: {
                    Rows: response.RowData.Data,
                    Columns: response.Columns,
                    PageCount: response.PageCount,

                    CurrentPageIndex: currentPageIndex,
                    LookupName: lookupName,
                    LookupFilter: lookupFilter,

                    KeyField1: response.KeyField1,
                    KeyField2: response.KeyField2,
                    KeyField3: response.KeyField3,

                    KeyFieldValue1: null,
                    KeyFieldValue2: null,
                    KeyFieldValue3: null,

                    Parent: parent
                    
                },
                computed:
                {
                        PagerDisplay: function () {
                            var self = this;
                            let PAGE_NUMBER = 10;
                            let min = 0;
                            let max = 0;

                            if (self.PageCount <= PAGE_NUMBER) {
                                min = 1;
                                max = Math.min(self.PageCount, PAGE_NUMBER);
                            } else {
                                if (self.CurrentPageIndex < 6) {
                                    min = 1;
                                    max = PAGE_NUMBER;
                                } else {
                                    min = self.CurrentPageIndex;
                                    max = Math.min(self.CurrentPageIndex + 4, self.PageCount);
                                    let vcount = max - min + 1;
                                    if (vcount < PAGE_NUMBER) {
                                        let number1 = max - min + 1;
                                        min = self.CurrentPageIndex - (PAGE_NUMBER - number1);
                                    }
                                }
                            }

                            var pageList = [];
                            for (var i = min; i <= max; i++) {
                                pageList.push(i);
                            }
                            console.log("pageList", pageList);
                            return pageList;
                        }  
                    },
                ready: function () {
                    //this.getCustomers();
                },
                methods: {
                    OnOKClick: function (event:any) {
                        this.Parent.dialogClose();  
                        var texbox = jQuery("#" +this.Parent.TargetId);
                        texbox.val(this.KeyFieldValue1);
                    },

                    OnCloseClick: function (event) {
                        this.Parent.dialogClose();  
                    },

                    OnNextPageClick: function (event) {
                        this.CurrentPageIndex = this.CurrentPageIndex + 1;
                        this.GetData(this.LookupName, this.LookupFilter, this.CurrentPageIndex);
                    },

                    OnPreviousClick: function (event) {
                        this.CurrentPageIndex = this.CurrentPageIndex -1;
                        this.GetData(this.LookupName, this.LookupFilter, this.CurrentPageIndex);
                    },

                    OnPagerClick: function (pageIndex) {
                        console.log("PagerClick", pageIndex);
                        this.CurrentPageIndex = pageIndex;
                        this.GetData(this.LookupName, this.LookupFilter, pageIndex);
                    },

                    OnNonPagerClick: function (event) {
                        if (event)
                            event.preventDefault();
                    },

                    OnRowClick: function(event:any,row: any) {
                        console.log("select row", row);
                        var key1 = row[this.KeyField1];
                        this.KeyFieldValue1 = key1;
                    },  
                    
                    GetData: function (lookupName: string, lookupFilter: string, currentPageIndex: number) {
                        var data = {
                            LookupName: lookupName,
                            LookupFilter: lookupFilter,
                            CurrentPageIndex: currentPageIndex
                        };
                          
                        Matrix.Administration.TranslationService.Lookup(data,
                            response => {
                                console.log("GetData response in page changed :", response);
                                this.Rows = response.RowData.Data,
                                this.Columns = response.Columns;
                                this.PageCount = response.PageCount;
                            });
                    }
                }
            });
        }

        protected getDialogOptions() {
            var opt = super.getDialogOptions();
            //opt.position = {  my: "center",  at: "center",  of: window  };
            return opt;  
        }
    }
}