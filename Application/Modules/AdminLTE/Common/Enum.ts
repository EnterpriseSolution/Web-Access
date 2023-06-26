namespace Matrix {
    export class ItemTypeOption {
        Mapping: KeyedCollection<string>;
        constructor() {
            this.Mapping = new KeyedCollection<string>();
            this.Mapping.Add("STD", "Standard Stocked Item");  
            this.Mapping.Add("STA", "Standard Assortment");   
            this.Mapping.Add("CFA", "Configurable Assortment");  
            this.Mapping.Add("NSI", "Non-Stocked Item");  
        }
    }

    
    export class NavigationIcon {
        Mapping: KeyedCollection<string>;
        constructor() {
            this.Mapping = new KeyedCollection<string>();
            this.Mapping.Add("Reports", "fa-th");
            this.Mapping.Add("Setup", "fa-cog");
            this.Mapping.Add("Data Import", "fa-refresh");
            this.Mapping.Add("Enquiries", "fa-tv");
        }
    }
}