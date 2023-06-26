namespace Matrix.MasterData {
    export interface CommodityRow {
        Recnum?: number;
        CustomProdCode?: string;
        CustomSerialNo?: string;
        CustomProdDesc?: string;
        CustomProdNo?: string;
        CustomEng?: string;
        CustomEngNo?: string;
        CustomMeasUom?: string;
        CustomCcy?: string;
        CustomPrice?: number;
        CustomExempt?: string;
        CustomFee?: number;
        CustomRemark?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace CommodityRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CustomProdCode';
        export const localTextPrefix = 'MasterData.Commodity';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CustomProdCode: string;
            export declare const CustomSerialNo: string;
            export declare const CustomProdDesc: string;
            export declare const CustomProdNo: string;
            export declare const CustomEng: string;
            export declare const CustomEngNo: string;
            export declare const CustomMeasUom: string;
            export declare const CustomCcy: string;
            export declare const CustomPrice: string;
            export declare const CustomExempt: string;
            export declare const CustomFee: string;
            export declare const CustomRemark: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Recnum', 
            'CustomProdCode', 
            'CustomSerialNo', 
            'CustomProdDesc', 
            'CustomProdNo', 
            'CustomEng', 
            'CustomEngNo', 
            'CustomMeasUom', 
            'CustomCcy', 
            'CustomPrice', 
            'CustomExempt', 
            'CustomFee', 
            'CustomRemark', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

