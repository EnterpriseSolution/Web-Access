namespace Matrix.Inventory.Repositories {
    export interface StockJournalListRequest extends Serenity.ListRequest {
        Location?: string;
        ItemNo?: string;
    }
}

