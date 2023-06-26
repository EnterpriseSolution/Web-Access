namespace Matrix.EnterpriseSys {
    export interface ReportPreviewRequest extends Serenity.ServiceRequest {
        ReportId?: string;
        Values?: ReportPreviewUserInput[];
    }
}

