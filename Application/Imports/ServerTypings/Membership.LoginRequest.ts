namespace Matrix.Membership {
    export interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string;
        Password?: string;
        CompanyCode?: string;
    }
}

