namespace Matrix.Administration {
    export interface TranslationRow {
        LanguageCode?: string;
        KeyText?: string;
        DisplayText?: string;
    }

    export namespace TranslationRow {
        export const nameProperty = 'DisplayText';
        export const localTextPrefix = 'Administration.Translation';

        export namespace Fields {
            export declare const LanguageCode: string;
            export declare const KeyText: string;
            export declare const DisplayText: string;
        }

        [
            'LanguageCode', 
            'KeyText', 
            'DisplayText'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

