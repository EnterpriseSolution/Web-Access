#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyParameterRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Basic.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Basic"), TableName("[dbo].[GBPARM]")]
    [DisplayName("Company Parameter"), InstanceName("Operation Settings"), TwoLevelCached]   
    public sealed class CompanyParameterRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Company Name"), Column("COMPANY_NAME"), Size(50), QuickSearch]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Address"), Column("ADDRESS"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Address2"), Column("ADDRESS2"), Size(40)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName("Address3"), Column("ADDRESS3"), Size(30)]
        public String Address3
        {
            get { return Fields.Address3[this]; }
            set { Fields.Address3[this] = value; }
        }

        [DisplayName("Address4"), Column("ADDRESS4"), Size(30)]
        public String Address4
        {
            get { return Fields.Address4[this]; }
            set { Fields.Address4[this] = value; }
        }

        [DisplayName("Post Code"), Column("POST_CODE"), Size(15)]
        public String PostCode
        {
            get { return Fields.PostCode[this]; }
            set { Fields.PostCode[this] = value; }
        }

        [DisplayName("Tel No"), Column("TEL_NO"), Size(30)]
        public String TelNo
        {
            get { return Fields.TelNo[this]; }
            set { Fields.TelNo[this] = value; }
        }

        [DisplayName("Fax No"), Column("FAX_NO"), Size(30)]
        public String FaxNo
        {
            get { return Fields.FaxNo[this]; }
            set { Fields.FaxNo[this] = value; }
        }

        [DisplayName("Email"), Column("EMAIL"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Tax Acct No"), Column("TAX_ACCT_NO"), Size(20)]
        public String TaxAcctNo
        {
            get { return Fields.TaxAcctNo[this]; }
            set { Fields.TaxAcctNo[this] = value; }
        }

        [DisplayName("Bus Reg No"), Column("BUS_REG_NO"), Size(20)]
        public String BusRegNo
        {
            get { return Fields.BusRegNo[this]; }
            set { Fields.BusRegNo[this] = value; }
        }

        [DisplayName("Drevised Date"), Column("DREVISED_DATE")]
        public DateTime? DrevisedDate
        {
            get { return Fields.DrevisedDate[this]; }
            set { Fields.DrevisedDate[this] = value; }
        }

        [DisplayName("Drevised By"), Column("DREVISED_BY"), Size(10)]
        public String DrevisedBy
        {
            get { return Fields.DrevisedBy[this]; }
            set { Fields.DrevisedBy[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4)]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Base Currency"), Column("BASE_CURRENCY"), Size(4)]
        public String BaseCurrency
        {
            get { return Fields.BaseCurrency[this]; }
            set { Fields.BaseCurrency[this] = value; }
        }

        [DisplayName("No Of Periods"), Column("NO_OF_PERIODS"), Size(2)]
        public Decimal? NoOfPeriods
        {
            get { return Fields.NoOfPeriods[this]; }
            set { Fields.NoOfPeriods[this] = value; }
        }

        [DisplayName("Current Period"), Column("CURRENT_PERIOD"), Size(7)]
        public String CurrentPeriod
        {
            get { return Fields.CurrentPeriod[this]; }
            set { Fields.CurrentPeriod[this] = value; }
        }

        [DisplayName("Open Prd From"), Column("OPEN_PRD_FROM"), Size(7)]
        public String OpenPrdFrom
        {
            get { return Fields.OpenPrdFrom[this]; }
            set { Fields.OpenPrdFrom[this] = value; }
        }

        [DisplayName("Open Prd To"), Column("OPEN_PRD_TO"), Size(7)]
        public String OpenPrdTo
        {
            get { return Fields.OpenPrdTo[this]; }
            set { Fields.OpenPrdTo[this] = value; }
        }

        [DisplayName("Allow Entries"), Column("ALLOW_ENTRIES"), Size(1)]
        public String AllowEntries
        {
            get { return Fields.AllowEntries[this]; }
            set { Fields.AllowEntries[this] = value; }
        }

        [DisplayName("Acct Ret Earn"), Column("ACCT_RET_EARN"), Size(30)]
        public String AcctRetEarn
        {
            get { return Fields.AcctRetEarn[this]; }
            set { Fields.AcctRetEarn[this] = value; }
        }

        [DisplayName("Acct Cur Earn"), Column("ACCT_CUR_EARN"), Size(30)]
        public String AcctCurEarn
        {
            get { return Fields.AcctCurEarn[this]; }
            set { Fields.AcctCurEarn[this] = value; }
        }

        [DisplayName("Acct End Bs"), Column("ACCT_END_BS"), Size(30)]
        public String AcctEndBs
        {
            get { return Fields.AcctEndBs[this]; }
            set { Fields.AcctEndBs[this] = value; }
        }

        [DisplayName("Loc Receiving"), Column("LOC_RECEIVING"), Size(4)]
        public String LocReceiving
        {
            get { return Fields.LocReceiving[this]; }
            set { Fields.LocReceiving[this] = value; }
        }

        [DisplayName("Loc Shipment"), Column("LOC_SHIPMENT"), Size(4)]
        public String LocShipment
        {
            get { return Fields.LocShipment[this]; }
            set { Fields.LocShipment[this] = value; }
        }

        [DisplayName("Loc Pos"), Column("LOC_POS"), Size(4)]
        public String LocPos
        {
            get { return Fields.LocPos[this]; }
            set { Fields.LocPos[this] = value; }
        }

        [DisplayName("Loc Material"), Column("LOC_MATERIAL"), Size(4)]
        public String LocMaterial
        {
            get { return Fields.LocMaterial[this]; }
            set { Fields.LocMaterial[this] = value; }
        }

        [DisplayName("Loc Produce"), Column("LOC_PRODUCE"), Size(4)]
        public String LocProduce
        {
            get { return Fields.LocProduce[this]; }
            set { Fields.LocProduce[this] = value; }
        }

        [DisplayName("Ic Revaluation"), Column("IC_REVALUATION"), Size(1)]
        public String IcRevaluation
        {
            get { return Fields.IcRevaluation[this]; }
            set { Fields.IcRevaluation[this] = value; }
        }

        [DisplayName("Fg Std Costing"), Column("FG_STD_COSTING"), Size(1)]
        public String FgStdCosting
        {
            get { return Fields.FgStdCosting[this]; }
            set { Fields.FgStdCosting[this] = value; }
        }

        [DisplayName("Alloc Method"), Column("ALLOC_METHOD"), Size(1)]
        public String AllocMethod
        {
            get { return Fields.AllocMethod[this]; }
            set { Fields.AllocMethod[this] = value; }
        }

        [DisplayName("Costing Method"), Column("COSTING_METHOD"), Size(1)]
        public String CostingMethod
        {
            get { return Fields.CostingMethod[this]; }
            set { Fields.CostingMethod[this] = value; }
        }

        [DisplayName("Allow Lot Opt"), Column("ALLOW_LOT_OPT"), Size(1)]
        public String AllowLotOpt
        {
            get { return Fields.AllowLotOpt[this]; }
            set { Fields.AllowLotOpt[this] = value; }
        }

        [DisplayName("Pmnt Fund Code"), Column("PMNT_FUND_CODE"), Size(6)]
        public String PmntFundCode
        {
            get { return Fields.PmntFundCode[this]; }
            set { Fields.PmntFundCode[this] = value; }
        }

        [DisplayName("Rcpt Fund Code"), Column("RCPT_FUND_CODE"), Size(6)]
        public String RcptFundCode
        {
            get { return Fields.RcptFundCode[this]; }
            set { Fields.RcptFundCode[this] = value; }
        }

        [DisplayName("Sales Pay Terms"), Column("SALES_PAY_TERMS"), Size(6)]
        public String SalesPayTerms
        {
            get { return Fields.SalesPayTerms[this]; }
            set { Fields.SalesPayTerms[this] = value; }
        }

        [DisplayName("Purch Pay Terms"), Column("PURCH_PAY_TERMS"), Size(6)]
        public String PurchPayTerms
        {
            get { return Fields.PurchPayTerms[this]; }
            set { Fields.PurchPayTerms[this] = value; }
        }

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10)]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        [DisplayName("Customer Group"), Column("CUSTOMER_GROUP"), Size(6)]
        public String CustomerGroup
        {
            get { return Fields.CustomerGroup[this]; }
            set { Fields.CustomerGroup[this] = value; }
        }

        [DisplayName("Vendor Group"), Column("VENDOR_GROUP"), Size(6)]
        public String VendorGroup
        {
            get { return Fields.VendorGroup[this]; }
            set { Fields.VendorGroup[this] = value; }
        }

        [DisplayName("Sl Cgtax Code"), Column("SL_CGTAX_CODE"), Size(6)]
        public String SlCgtaxCode
        {
            get { return Fields.SlCgtaxCode[this]; }
            set { Fields.SlCgtaxCode[this] = value; }
        }

        [DisplayName("Sl Cltax Code"), Column("SL_CLTAX_CODE"), Size(6)]
        public String SlCltaxCode
        {
            get { return Fields.SlCltaxCode[this]; }
            set { Fields.SlCltaxCode[this] = value; }
        }

        [DisplayName("Sl Vgtax Code"), Column("SL_VGTAX_CODE"), Size(6)]
        public String SlVgtaxCode
        {
            get { return Fields.SlVgtaxCode[this]; }
            set { Fields.SlVgtaxCode[this] = value; }
        }

        [DisplayName("Sl Vltax Code"), Column("SL_VLTAX_CODE"), Size(6)]
        public String SlVltaxCode
        {
            get { return Fields.SlVltaxCode[this]; }
            set { Fields.SlVltaxCode[this] = value; }
        }

        [DisplayName("Sl Itax Code"), Column("SL_ITAX_CODE"), Size(6)]
        public String SlItaxCode
        {
            get { return Fields.SlItaxCode[this]; }
            set { Fields.SlItaxCode[this] = value; }
        }

        [DisplayName("Pu Cgtax Code"), Column("PU_CGTAX_CODE"), Size(6)]
        public String PuCgtaxCode
        {
            get { return Fields.PuCgtaxCode[this]; }
            set { Fields.PuCgtaxCode[this] = value; }
        }

        [DisplayName("Pu Cltax Code"), Column("PU_CLTAX_CODE"), Size(6)]
        public String PuCltaxCode
        {
            get { return Fields.PuCltaxCode[this]; }
            set { Fields.PuCltaxCode[this] = value; }
        }

        [DisplayName("Pu Vgtax Code"), Column("PU_VGTAX_CODE"), Size(6)]
        public String PuVgtaxCode
        {
            get { return Fields.PuVgtaxCode[this]; }
            set { Fields.PuVgtaxCode[this] = value; }
        }

        [DisplayName("Pu Vltax Code"), Column("PU_VLTAX_CODE"), Size(6)]
        public String PuVltaxCode
        {
            get { return Fields.PuVltaxCode[this]; }
            set { Fields.PuVltaxCode[this] = value; }
        }

        [DisplayName("Pu Itax Code"), Column("PU_ITAX_CODE"), Size(6)]
        public String PuItaxCode
        {
            get { return Fields.PuItaxCode[this]; }
            set { Fields.PuItaxCode[this] = value; }
        }

        [DisplayName("With Taxation"), Column("WITH_TAXATION"), Size(1)]
        public String WithTaxation
        {
            get { return Fields.WithTaxation[this]; }
            set { Fields.WithTaxation[this] = value; }
        }

        [DisplayName("Proc Sales Gtax"), Column("PROC_SALES_GTAX"), Size(1)]
        public String ProcSalesGtax
        {
            get { return Fields.ProcSalesGtax[this]; }
            set { Fields.ProcSalesGtax[this] = value; }
        }

        [DisplayName("Proc Sales Ltax"), Column("PROC_SALES_LTAX"), Size(1)]
        public String ProcSalesLtax
        {
            get { return Fields.ProcSalesLtax[this]; }
            set { Fields.ProcSalesLtax[this] = value; }
        }

        [DisplayName("Proc Purch Gtax"), Column("PROC_PURCH_GTAX"), Size(1)]
        public String ProcPurchGtax
        {
            get { return Fields.ProcPurchGtax[this]; }
            set { Fields.ProcPurchGtax[this] = value; }
        }

        [DisplayName("Proc Purch Ltax"), Column("PROC_PURCH_LTAX"), Size(1)]
        public String ProcPurchLtax
        {
            get { return Fields.ProcPurchLtax[this]; }
            set { Fields.ProcPurchLtax[this] = value; }
        }

        [DisplayName("Trevised Date"), Column("TREVISED_DATE")]
        public DateTime? TrevisedDate
        {
            get { return Fields.TrevisedDate[this]; }
            set { Fields.TrevisedDate[this] = value; }
        }

        [DisplayName("Trevised By"), Column("TREVISED_BY"), Size(10)]
        public String TrevisedBy
        {
            get { return Fields.TrevisedBy[this]; }
            set { Fields.TrevisedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Alt Name"), Column("ALT_NAME"), Size(50)]
        public String AltName
        {
            get { return Fields.AltName[this]; }
            set { Fields.AltName[this] = value; }
        }

        [DisplayName("Alt Address"), Column("ALT_ADDRESS"), Size(50)]
        public String AltAddress
        {
            get { return Fields.AltAddress[this]; }
            set { Fields.AltAddress[this] = value; }
        }

        [DisplayName("Alt Address2"), Column("ALT_ADDRESS2"), Size(40)]
        public String AltAddress2
        {
            get { return Fields.AltAddress2[this]; }
            set { Fields.AltAddress2[this] = value; }
        }

        [DisplayName("Alt Address3"), Column("ALT_ADDRESS3"), Size(30)]
        public String AltAddress3
        {
            get { return Fields.AltAddress3[this]; }
            set { Fields.AltAddress3[this] = value; }
        }

        [DisplayName("Alt Address4"), Column("ALT_ADDRESS4"), Size(30)]
        public String AltAddress4
        {
            get { return Fields.AltAddress4[this]; }
            set { Fields.AltAddress4[this] = value; }
        }

        [DisplayName("Main Bran Path"), Column("MAIN_BRAN_PATH"), Size(40)]
        public String MainBranPath
        {
            get { return Fields.MainBranPath[this]; }
            set { Fields.MainBranPath[this] = value; }
        }

        [DisplayName("Main Bran Count"), Column("MAIN_BRAN_COUNT"), Size(2)]
        public Decimal? MainBranCount
        {
            get { return Fields.MainBranCount[this]; }
            set { Fields.MainBranCount[this] = value; }
        }

        [DisplayName("Online Bran Upd"), Column("ONLINE_BRAN_UPD"), Size(1)]
        public String OnlineBranUpd
        {
            get { return Fields.OnlineBranUpd[this]; }
            set { Fields.OnlineBranUpd[this] = value; }
        }

        [DisplayName("With Cost Ctr"), Column("WITH_COST_CTR"), Size(1)]
        public String WithCostCtr
        {
            get { return Fields.WithCostCtr[this]; }
            set { Fields.WithCostCtr[this] = value; }
        }

        [DisplayName("With Dept"), Column("WITH_DEPT"), Size(1)]
        public String WithDept
        {
            get { return Fields.WithDept[this]; }
            set { Fields.WithDept[this] = value; }
        }

        [DisplayName("With Bin Ctrl"), Column("WITH_BIN_CTRL"), Size(1)]
        public String WithBinCtrl
        {
            get { return Fields.WithBinCtrl[this]; }
            set { Fields.WithBinCtrl[this] = value; }
        }

        [DisplayName("With Inspection"), Column("WITH_INSPECTION"), Size(1)]
        public String WithInspection
        {
            get { return Fields.WithInspection[this]; }
            set { Fields.WithInspection[this] = value; }
        }

        [DisplayName("Acct Itm Asset"), Column("ACCT_ITM_ASSET"), Size(30)]
        public String AcctItmAsset
        {
            get { return Fields.AcctItmAsset[this]; }
            set { Fields.AcctItmAsset[this] = value; }
        }

        [DisplayName("Acct Itm Wip"), Column("ACCT_ITM_WIP"), Size(30)]
        public String AcctItmWip
        {
            get { return Fields.AcctItmWip[this]; }
            set { Fields.AcctItmWip[this] = value; }
        }

        [DisplayName("Acct Itm Consum"), Column("ACCT_ITM_CONSUM"), Size(30)]
        public String AcctItmConsum
        {
            get { return Fields.AcctItmConsum[this]; }
            set { Fields.AcctItmConsum[this] = value; }
        }

        [DisplayName("Acct Itm Scrap"), Column("ACCT_ITM_SCRAP"), Size(30)]
        public String AcctItmScrap
        {
            get { return Fields.AcctItmScrap[this]; }
            set { Fields.AcctItmScrap[this] = value; }
        }

        [DisplayName("Acct Itm Pvar"), Column("ACCT_ITM_PVAR"), Size(30)]
        public String AcctItmPvar
        {
            get { return Fields.AcctItmPvar[this]; }
            set { Fields.AcctItmPvar[this] = value; }
        }

        [DisplayName("Acct Itm Reval"), Column("ACCT_ITM_REVAL"), Size(30)]
        public String AcctItmReval
        {
            get { return Fields.AcctItmReval[this]; }
            set { Fields.AcctItmReval[this] = value; }
        }

        [DisplayName("Acct Itm Varia"), Column("ACCT_ITM_VARIA"), Size(30)]
        public String AcctItmVaria
        {
            get { return Fields.AcctItmVaria[this]; }
            set { Fields.AcctItmVaria[this] = value; }
        }

        [DisplayName("Acct Itm Sales"), Column("ACCT_ITM_SALES"), Size(30)]
        public String AcctItmSales
        {
            get { return Fields.AcctItmSales[this]; }
            set { Fields.AcctItmSales[this] = value; }
        }

        [DisplayName("Acct Itm Slret"), Column("ACCT_ITM_SLRET"), Size(30)]
        public String AcctItmSlret
        {
            get { return Fields.AcctItmSlret[this]; }
            set { Fields.AcctItmSlret[this] = value; }
        }

        [DisplayName("Acct Itm Sldisc"), Column("ACCT_ITM_SLDISC"), Size(30)]
        public String AcctItmSldisc
        {
            get { return Fields.AcctItmSldisc[this]; }
            set { Fields.AcctItmSldisc[this] = value; }
        }

        [DisplayName("Acct Itm Cogs"), Column("ACCT_ITM_COGS"), Size(30)]
        public String AcctItmCogs
        {
            get { return Fields.AcctItmCogs[this]; }
            set { Fields.AcctItmCogs[this] = value; }
        }

        [DisplayName("Acct Itm Purch"), Column("ACCT_ITM_PURCH"), Size(30)]
        public String AcctItmPurch
        {
            get { return Fields.AcctItmPurch[this]; }
            set { Fields.AcctItmPurch[this] = value; }
        }

        [DisplayName("Acct Itm Puret"), Column("ACCT_ITM_PURET"), Size(30)]
        public String AcctItmPuret
        {
            get { return Fields.AcctItmPuret[this]; }
            set { Fields.AcctItmPuret[this] = value; }
        }

        [DisplayName("Acct Itm Pudisc"), Column("ACCT_ITM_PUDISC"), Size(30)]
        public String AcctItmPudisc
        {
            get { return Fields.AcctItmPudisc[this]; }
            set { Fields.AcctItmPudisc[this] = value; }
        }

        [DisplayName("Acct Itm Putax"), Column("ACCT_ITM_PUTAX"), Size(30)]
        public String AcctItmPutax
        {
            get { return Fields.AcctItmPutax[this]; }
            set { Fields.AcctItmPutax[this] = value; }
        }

        [DisplayName("Acct Mvt Issue"), Column("ACCT_MVT_ISSUE"), Size(30)]
        public String AcctMvtIssue
        {
            get { return Fields.AcctMvtIssue[this]; }
            set { Fields.AcctMvtIssue[this] = value; }
        }

        [DisplayName("Acct Mvt Rcpt"), Column("ACCT_MVT_RCPT"), Size(30)]
        public String AcctMvtRcpt
        {
            get { return Fields.AcctMvtRcpt[this]; }
            set { Fields.AcctMvtRcpt[this] = value; }
        }

        [DisplayName("Acct Mvt Adj"), Column("ACCT_MVT_ADJ"), Size(30)]
        public String AcctMvtAdj
        {
            get { return Fields.AcctMvtAdj[this]; }
            set { Fields.AcctMvtAdj[this] = value; }
        }

        [DisplayName("Acct Sls Misc"), Column("ACCT_SLS_MISC"), Size(30)]
        public String AcctSlsMisc
        {
            get { return Fields.AcctSlsMisc[this]; }
            set { Fields.AcctSlsMisc[this] = value; }
        }

        [DisplayName("Acct Sls Mscret"), Column("ACCT_SLS_MSCRET"), Size(30)]
        public String AcctSlsMscret
        {
            get { return Fields.AcctSlsMscret[this]; }
            set { Fields.AcctSlsMscret[this] = value; }
        }

        [DisplayName("Acct Sls Trdisc"), Column("ACCT_SLS_TRDISC"), Size(30)]
        public String AcctSlsTrdisc
        {
            get { return Fields.AcctSlsTrdisc[this]; }
            set { Fields.AcctSlsTrdisc[this] = value; }
        }

        [DisplayName("Acct Sls Lntax"), Column("ACCT_SLS_LNTAX"), Size(30)]
        public String AcctSlsLntax
        {
            get { return Fields.AcctSlsLntax[this]; }
            set { Fields.AcctSlsLntax[this] = value; }
        }

        [DisplayName("Acct Sls Grtax"), Column("ACCT_SLS_GRTAX"), Size(30)]
        public String AcctSlsGrtax
        {
            get { return Fields.AcctSlsGrtax[this]; }
            set { Fields.AcctSlsGrtax[this] = value; }
        }

        [DisplayName("Acct Pur Misc"), Column("ACCT_PUR_MISC"), Size(30)]
        public String AcctPurMisc
        {
            get { return Fields.AcctPurMisc[this]; }
            set { Fields.AcctPurMisc[this] = value; }
        }

        [DisplayName("Acct Pur Mscret"), Column("ACCT_PUR_MSCRET"), Size(30)]
        public String AcctPurMscret
        {
            get { return Fields.AcctPurMscret[this]; }
            set { Fields.AcctPurMscret[this] = value; }
        }

        [DisplayName("Acct Pur Trdisc"), Column("ACCT_PUR_TRDISC"), Size(30)]
        public String AcctPurTrdisc
        {
            get { return Fields.AcctPurTrdisc[this]; }
            set { Fields.AcctPurTrdisc[this] = value; }
        }

        [DisplayName("Acct Pur Grtax"), Column("ACCT_PUR_GRTAX"), Size(30)]
        public String AcctPurGrtax
        {
            get { return Fields.AcctPurGrtax[this]; }
            set { Fields.AcctPurGrtax[this] = value; }
        }

        [DisplayName("Acct Ar Cash"), Column("ACCT_AR_CASH"), Size(30)]
        public String AcctArCash
        {
            get { return Fields.AcctArCash[this]; }
            set { Fields.AcctArCash[this] = value; }
        }

        [DisplayName("Acct Ar Cust"), Column("ACCT_AR_CUST"), Size(30)]
        public String AcctArCust
        {
            get { return Fields.AcctArCust[this]; }
            set { Fields.AcctArCust[this] = value; }
        }

        [DisplayName("Acct Ar Disc"), Column("ACCT_AR_DISC"), Size(30)]
        public String AcctArDisc
        {
            get { return Fields.AcctArDisc[this]; }
            set { Fields.AcctArDisc[this] = value; }
        }

        [DisplayName("Acct Ar Adj"), Column("ACCT_AR_ADJ"), Size(30)]
        public String AcctArAdj
        {
            get { return Fields.AcctArAdj[this]; }
            set { Fields.AcctArAdj[this] = value; }
        }

        [DisplayName("Acct Ar Forex"), Column("ACCT_AR_FOREX"), Size(30)]
        public String AcctArForex
        {
            get { return Fields.AcctArForex[this]; }
            set { Fields.AcctArForex[this] = value; }
        }

        [DisplayName("Acct Ap Cash"), Column("ACCT_AP_CASH"), Size(30)]
        public String AcctApCash
        {
            get { return Fields.AcctApCash[this]; }
            set { Fields.AcctApCash[this] = value; }
        }

        [DisplayName("Acct Ap Vend"), Column("ACCT_AP_VEND"), Size(30)]
        public String AcctApVend
        {
            get { return Fields.AcctApVend[this]; }
            set { Fields.AcctApVend[this] = value; }
        }

        [DisplayName("Acct Ap Disc"), Column("ACCT_AP_DISC"), Size(30)]
        public String AcctApDisc
        {
            get { return Fields.AcctApDisc[this]; }
            set { Fields.AcctApDisc[this] = value; }
        }

        [DisplayName("Acct Ap Adj"), Column("ACCT_AP_ADJ"), Size(30)]
        public String AcctApAdj
        {
            get { return Fields.AcctApAdj[this]; }
            set { Fields.AcctApAdj[this] = value; }
        }

        [DisplayName("Acct Ap Forex"), Column("ACCT_AP_FOREX"), Size(30)]
        public String AcctApForex
        {
            get { return Fields.AcctApForex[this]; }
            set { Fields.AcctApForex[this] = value; }
        }

        [DisplayName("Acct Ap Varia"), Column("ACCT_AP_VARIA"), Size(30)]
        public String AcctApVaria
        {
            get { return Fields.AcctApVaria[this]; }
            set { Fields.AcctApVaria[this] = value; }
        }

        [DisplayName("Acct Machine"), Column("ACCT_MACHINE"), Size(30)]
        public String AcctMachine
        {
            get { return Fields.AcctMachine[this]; }
            set { Fields.AcctMachine[this] = value; }
        }

        [DisplayName("Acct Energy"), Column("ACCT_ENERGY"), Size(30)]
        public String AcctEnergy
        {
            get { return Fields.AcctEnergy[this]; }
            set { Fields.AcctEnergy[this] = value; }
        }

        [DisplayName("Acct Water"), Column("ACCT_WATER"), Size(30)]
        public String AcctWater
        {
            get { return Fields.AcctWater[this]; }
            set { Fields.AcctWater[this] = value; }
        }

        [DisplayName("Acct Rental"), Column("ACCT_RENTAL"), Size(30)]
        public String AcctRental
        {
            get { return Fields.AcctRental[this]; }
            set { Fields.AcctRental[this] = value; }
        }

        [DisplayName("Acct Labor"), Column("ACCT_LABOR"), Size(30)]
        public String AcctLabor
        {
            get { return Fields.AcctLabor[this]; }
            set { Fields.AcctLabor[this] = value; }
        }

        [DisplayName("Acct Inlab"), Column("ACCT_INLAB"), Size(30)]
        public String AcctInlab
        {
            get { return Fields.AcctInlab[this]; }
            set { Fields.AcctInlab[this] = value; }
        }

        [DisplayName("Acct Inmat"), Column("ACCT_INMAT"), Size(30)]
        public String AcctInmat
        {
            get { return Fields.AcctInmat[this]; }
            set { Fields.AcctInmat[this] = value; }
        }

        [DisplayName("Acct Misc"), Column("ACCT_MISC"), Size(30)]
        public String AcctMisc
        {
            get { return Fields.AcctMisc[this]; }
            set { Fields.AcctMisc[this] = value; }
        }

        [DisplayName("Acct Susp Ar"), Column("ACCT_SUSP_AR"), Size(30)]
        public String AcctSuspAr
        {
            get { return Fields.AcctSuspAr[this]; }
            set { Fields.AcctSuspAr[this] = value; }
        }

        [DisplayName("Acct Susp Ap"), Column("ACCT_SUSP_AP"), Size(30)]
        public String AcctSuspAp
        {
            get { return Fields.AcctSuspAp[this]; }
            set { Fields.AcctSuspAp[this] = value; }
        }

        [DisplayName("Acct Susp Ic"), Column("ACCT_SUSP_IC"), Size(30)]
        public String AcctSuspIc
        {
            get { return Fields.AcctSuspIc[this]; }
            set { Fields.AcctSuspIc[this] = value; }
        }

        [DisplayName("Acct Susp Pr"), Column("ACCT_SUSP_PR"), Size(30)]
        public String AcctSuspPr
        {
            get { return Fields.AcctSuspPr[this]; }
            set { Fields.AcctSuspPr[this] = value; }
        }

        [DisplayName("Acct Susp Fa"), Column("ACCT_SUSP_FA"), Size(30)]
        public String AcctSuspFa
        {
            get { return Fields.AcctSuspFa[this]; }
            set { Fields.AcctSuspFa[this] = value; }
        }

        [DisplayName("Acct Susp Sub"), Column("ACCT_SUSP_SUB"), Size(30)]
        public String AcctSuspSub
        {
            get { return Fields.AcctSuspSub[this]; }
            set { Fields.AcctSuspSub[this] = value; }
        }

        [DisplayName("Acct Susp Incom"), Column("ACCT_SUSP_INCOM"), Size(30)]
        public String AcctSuspIncom
        {
            get { return Fields.AcctSuspIncom[this]; }
            set { Fields.AcctSuspIncom[this] = value; }
        }

        [DisplayName("Acct Susp Expen"), Column("ACCT_SUSP_EXPEN"), Size(30)]
        public String AcctSuspExpen
        {
            get { return Fields.AcctSuspExpen[this]; }
            set { Fields.AcctSuspExpen[this] = value; }
        }

        [DisplayName("Arevised Date"), Column("AREVISED_DATE")]
        public DateTime? ArevisedDate
        {
            get { return Fields.ArevisedDate[this]; }
            set { Fields.ArevisedDate[this] = value; }
        }

        [DisplayName("Arevised By"), Column("AREVISED_BY"), Size(10)]
        public String ArevisedBy
        {
            get { return Fields.ArevisedBy[this]; }
            set { Fields.ArevisedBy[this] = value; }
        }

        [DisplayName("Brevised Date"), Column("BREVISED_DATE")]
        public DateTime? BrevisedDate
        {
            get { return Fields.BrevisedDate[this]; }
            set { Fields.BrevisedDate[this] = value; }
        }

        [DisplayName("Brevised By"), Column("BREVISED_BY"), Size(10)]
        public String BrevisedBy
        {
            get { return Fields.BrevisedBy[this]; }
            set { Fields.BrevisedBy[this] = value; }
        }

        [DisplayName("Dept Prod"), Column("DEPT_PROD"), Size(4)]
        public String DeptProd
        {
            get { return Fields.DeptProd[this]; }
            set { Fields.DeptProd[this] = value; }
        }

        [DisplayName("Dept Sales"), Column("DEPT_SALES"), Size(4)]
        public String DeptSales
        {
            get { return Fields.DeptSales[this]; }
            set { Fields.DeptSales[this] = value; }
        }

        [DisplayName("Dept Purch"), Column("DEPT_PURCH"), Size(4)]
        public String DeptPurch
        {
            get { return Fields.DeptPurch[this]; }
            set { Fields.DeptPurch[this] = value; }
        }

        [DisplayName("No Of Shift"), Column("NO_OF_SHIFT"), Size(2)]
        public Decimal? NoOfShift
        {
            get { return Fields.NoOfShift[this]; }
            set { Fields.NoOfShift[this] = value; }
        }

        [DisplayName("Shift1 Hrs"), Column("SHIFT1_HRS"), Size(2)]
        public Decimal? Shift1Hrs
        {
            get { return Fields.Shift1Hrs[this]; }
            set { Fields.Shift1Hrs[this] = value; }
        }

        [DisplayName("Shift2 Hrs"), Column("SHIFT2_HRS"), Size(2)]
        public Decimal? Shift2Hrs
        {
            get { return Fields.Shift2Hrs[this]; }
            set { Fields.Shift2Hrs[this] = value; }
        }

        [DisplayName("Shift3 Hrs"), Column("SHIFT3_HRS"), Size(2)]
        public Decimal? Shift3Hrs
        {
            get { return Fields.Shift3Hrs[this]; }
            set { Fields.Shift3Hrs[this] = value; }
        }

        [DisplayName("Shift1 Start"), Column("SHIFT1_START"), Size(4)]
        public String Shift1Start
        {
            get { return Fields.Shift1Start[this]; }
            set { Fields.Shift1Start[this] = value; }
        }

        [DisplayName("Shift2 Start"), Column("SHIFT2_START"), Size(4)]
        public String Shift2Start
        {
            get { return Fields.Shift2Start[this]; }
            set { Fields.Shift2Start[this] = value; }
        }

        [DisplayName("Shift3 Start"), Column("SHIFT3_START"), Size(4)]
        public String Shift3Start
        {
            get { return Fields.Shift3Start[this]; }
            set { Fields.Shift3Start[this] = value; }
        }

        [DisplayName("First Week Day"), Column("FIRST_WEEK_DAY"), Size(2)]
        public Decimal? FirstWeekDay
        {
            get { return Fields.FirstWeekDay[this]; }
            set { Fields.FirstWeekDay[this] = value; }
        }

        [DisplayName("Can Receive1"), Column("CAN_RECEIVE1"), Size(1)]
        public String CanReceive1
        {
            get { return Fields.CanReceive1[this]; }
            set { Fields.CanReceive1[this] = value; }
        }

        [DisplayName("Can Receive2"), Column("CAN_RECEIVE2"), Size(1)]
        public String CanReceive2
        {
            get { return Fields.CanReceive2[this]; }
            set { Fields.CanReceive2[this] = value; }
        }

        [DisplayName("Can Receive3"), Column("CAN_RECEIVE3"), Size(1)]
        public String CanReceive3
        {
            get { return Fields.CanReceive3[this]; }
            set { Fields.CanReceive3[this] = value; }
        }

        [DisplayName("Can Receive4"), Column("CAN_RECEIVE4"), Size(1)]
        public String CanReceive4
        {
            get { return Fields.CanReceive4[this]; }
            set { Fields.CanReceive4[this] = value; }
        }

        [DisplayName("Can Receive5"), Column("CAN_RECEIVE5"), Size(1)]
        public String CanReceive5
        {
            get { return Fields.CanReceive5[this]; }
            set { Fields.CanReceive5[this] = value; }
        }

        [DisplayName("Can Receive6"), Column("CAN_RECEIVE6"), Size(1)]
        public String CanReceive6
        {
            get { return Fields.CanReceive6[this]; }
            set { Fields.CanReceive6[this] = value; }
        }

        [DisplayName("Can Receive7"), Column("CAN_RECEIVE7"), Size(1)]
        public String CanReceive7
        {
            get { return Fields.CanReceive7[this]; }
            set { Fields.CanReceive7[this] = value; }
        }

        [DisplayName("Can Ship1"), Column("CAN_SHIP1"), Size(1)]
        public String CanShip1
        {
            get { return Fields.CanShip1[this]; }
            set { Fields.CanShip1[this] = value; }
        }

        [DisplayName("Can Ship2"), Column("CAN_SHIP2"), Size(1)]
        public String CanShip2
        {
            get { return Fields.CanShip2[this]; }
            set { Fields.CanShip2[this] = value; }
        }

        [DisplayName("Can Ship3"), Column("CAN_SHIP3"), Size(1)]
        public String CanShip3
        {
            get { return Fields.CanShip3[this]; }
            set { Fields.CanShip3[this] = value; }
        }

        [DisplayName("Can Ship4"), Column("CAN_SHIP4"), Size(1)]
        public String CanShip4
        {
            get { return Fields.CanShip4[this]; }
            set { Fields.CanShip4[this] = value; }
        }

        [DisplayName("Can Ship5"), Column("CAN_SHIP5"), Size(1)]
        public String CanShip5
        {
            get { return Fields.CanShip5[this]; }
            set { Fields.CanShip5[this] = value; }
        }

        [DisplayName("Can Ship6"), Column("CAN_SHIP6"), Size(1)]
        public String CanShip6
        {
            get { return Fields.CanShip6[this]; }
            set { Fields.CanShip6[this] = value; }
        }

        [DisplayName("Can Ship7"), Column("CAN_SHIP7"), Size(1)]
        public String CanShip7
        {
            get { return Fields.CanShip7[this]; }
            set { Fields.CanShip7[this] = value; }
        }

        [DisplayName("Is Holiday1"), Column("IS_HOLIDAY1"), Size(1)]
        public String IsHoliday1
        {
            get { return Fields.IsHoliday1[this]; }
            set { Fields.IsHoliday1[this] = value; }
        }

        [DisplayName("Is Holiday2"), Column("IS_HOLIDAY2"), Size(1)]
        public String IsHoliday2
        {
            get { return Fields.IsHoliday2[this]; }
            set { Fields.IsHoliday2[this] = value; }
        }

        [DisplayName("Is Holiday3"), Column("IS_HOLIDAY3"), Size(1)]
        public String IsHoliday3
        {
            get { return Fields.IsHoliday3[this]; }
            set { Fields.IsHoliday3[this] = value; }
        }

        [DisplayName("Is Holiday4"), Column("IS_HOLIDAY4"), Size(1)]
        public String IsHoliday4
        {
            get { return Fields.IsHoliday4[this]; }
            set { Fields.IsHoliday4[this] = value; }
        }

        [DisplayName("Is Holiday5"), Column("IS_HOLIDAY5"), Size(1)]
        public String IsHoliday5
        {
            get { return Fields.IsHoliday5[this]; }
            set { Fields.IsHoliday5[this] = value; }
        }

        [DisplayName("Is Holiday6"), Column("IS_HOLIDAY6"), Size(1)]
        public String IsHoliday6
        {
            get { return Fields.IsHoliday6[this]; }
            set { Fields.IsHoliday6[this] = value; }
        }

        [DisplayName("Is Holiday7"), Column("IS_HOLIDAY7"), Size(1)]
        public String IsHoliday7
        {
            get { return Fields.IsHoliday7[this]; }
            set { Fields.IsHoliday7[this] = value; }
        }

        [DisplayName("Half Day1"), Column("HALF_DAY1"), Size(1)]
        public String HalfDay1
        {
            get { return Fields.HalfDay1[this]; }
            set { Fields.HalfDay1[this] = value; }
        }

        [DisplayName("Half Day2"), Column("HALF_DAY2"), Size(1)]
        public String HalfDay2
        {
            get { return Fields.HalfDay2[this]; }
            set { Fields.HalfDay2[this] = value; }
        }

        [DisplayName("Half Day3"), Column("HALF_DAY3"), Size(1)]
        public String HalfDay3
        {
            get { return Fields.HalfDay3[this]; }
            set { Fields.HalfDay3[this] = value; }
        }

        [DisplayName("Half Day4"), Column("HALF_DAY4"), Size(1)]
        public String HalfDay4
        {
            get { return Fields.HalfDay4[this]; }
            set { Fields.HalfDay4[this] = value; }
        }

        [DisplayName("Half Day5"), Column("HALF_DAY5"), Size(1)]
        public String HalfDay5
        {
            get { return Fields.HalfDay5[this]; }
            set { Fields.HalfDay5[this] = value; }
        }

        [DisplayName("Half Day6"), Column("HALF_DAY6"), Size(1)]
        public String HalfDay6
        {
            get { return Fields.HalfDay6[this]; }
            set { Fields.HalfDay6[this] = value; }
        }

        [DisplayName("Half Day7"), Column("HALF_DAY7"), Size(1)]
        public String HalfDay7
        {
            get { return Fields.HalfDay7[this]; }
            set { Fields.HalfDay7[this] = value; }
        }

        [DisplayName("Crevised Date"), Column("CREVISED_DATE")]
        public DateTime? CrevisedDate
        {
            get { return Fields.CrevisedDate[this]; }
            set { Fields.CrevisedDate[this] = value; }
        }

        [DisplayName("Crevised By"), Column("CREVISED_BY"), Size(10)]
        public String CrevisedBy
        {
            get { return Fields.CrevisedBy[this]; }
            set { Fields.CrevisedBy[this] = value; }
        }

        [DisplayName("Log No Ship"), Column("LOG_NO_SHIP"), Size(8)]
        public Decimal? LogNoShip
        {
            get { return Fields.LogNoShip[this]; }
            set { Fields.LogNoShip[this] = value; }
        }

        [DisplayName("Log No Dlry"), Column("LOG_NO_DLRY"), Size(8)]
        public Decimal? LogNoDlry
        {
            get { return Fields.LogNoDlry[this]; }
            set { Fields.LogNoDlry[this] = value; }
        }

        [DisplayName("Log No Mvmt"), Column("LOG_NO_MVMT"), Size(8)]
        public Decimal? LogNoMvmt
        {
            get { return Fields.LogNoMvmt[this]; }
            set { Fields.LogNoMvmt[this] = value; }
        }

        [DisplayName("Log No Ar Open"), Column("LOG_NO_AR_OPEN"), Size(8)]
        public Decimal? LogNoArOpen
        {
            get { return Fields.LogNoArOpen[this]; }
            set { Fields.LogNoArOpen[this] = value; }
        }

        [DisplayName("Log No Ap Open"), Column("LOG_NO_AP_OPEN"), Size(8)]
        public Decimal? LogNoApOpen
        {
            get { return Fields.LogNoApOpen[this]; }
            set { Fields.LogNoApOpen[this] = value; }
        }

        [DisplayName("Log No Ledg"), Column("LOG_NO_LEDG"), Size(8)]
        public Decimal? LogNoLedg
        {
            get { return Fields.LogNoLedg[this]; }
            set { Fields.LogNoLedg[this] = value; }
        }

        [DisplayName("Invt Cost Avail"), Column("INVT_COST_AVAIL"), Size(16), Scale(2)]
        public Decimal? InvtCostAvail
        {
            get { return Fields.InvtCostAvail[this]; }
            set { Fields.InvtCostAvail[this] = value; }
        }

        [DisplayName("Invt Cost Ldg"), Column("INVT_COST_LDG"), Size(16), Scale(2)]
        public Decimal? InvtCostLdg
        {
            get { return Fields.InvtCostLdg[this]; }
            set { Fields.InvtCostLdg[this] = value; }
        }

        [DisplayName("On Sales Count"), Column("ON_SALES_COUNT"), Size(8)]
        public Decimal? OnSalesCount
        {
            get { return Fields.OnSalesCount[this]; }
            set { Fields.OnSalesCount[this] = value; }
        }

        [DisplayName("On Purch Count"), Column("ON_PURCH_COUNT"), Size(8)]
        public Decimal? OnPurchCount
        {
            get { return Fields.OnPurchCount[this]; }
            set { Fields.OnPurchCount[this] = value; }
        }

        [DisplayName("On Job Count"), Column("ON_JOB_COUNT"), Size(8)]
        public Decimal? OnJobCount
        {
            get { return Fields.OnJobCount[this]; }
            set { Fields.OnJobCount[this] = value; }
        }

        [DisplayName("Ar Invo Amt Bal"), Column("AR_INVO_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ArInvoAmtBal
        {
            get { return Fields.ArInvoAmtBal[this]; }
            set { Fields.ArInvoAmtBal[this] = value; }
        }

        [DisplayName("Ar Open Amt Bal"), Column("AR_OPEN_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ArOpenAmtBal
        {
            get { return Fields.ArOpenAmtBal[this]; }
            set { Fields.ArOpenAmtBal[this] = value; }
        }

        [DisplayName("Ar Net Amt Bal"), Column("AR_NET_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ArNetAmtBal
        {
            get { return Fields.ArNetAmtBal[this]; }
            set { Fields.ArNetAmtBal[this] = value; }
        }

        [DisplayName("Ap Invo Amt Bal"), Column("AP_INVO_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ApInvoAmtBal
        {
            get { return Fields.ApInvoAmtBal[this]; }
            set { Fields.ApInvoAmtBal[this] = value; }
        }

        [DisplayName("Ap Open Amt Bal"), Column("AP_OPEN_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ApOpenAmtBal
        {
            get { return Fields.ApOpenAmtBal[this]; }
            set { Fields.ApOpenAmtBal[this] = value; }
        }

        [DisplayName("Ap Net Amt Bal"), Column("AP_NET_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? ApNetAmtBal
        {
            get { return Fields.ApNetAmtBal[this]; }
            set { Fields.ApNetAmtBal[this] = value; }
        }

        [DisplayName("Verify Settings"), Column("VERIFY_SETTINGS"), Size(1)]
        [BoolStringConverter]
        public bool? VerifySettings
        {
            get { return Fields.VerifySettings[this]; }
            set { Fields.VerifySettings[this] = value; }
        }

        [DisplayName("Logo Bmp"), Column("LOGO_BMP"), Size(255)]
        public String LogoBmp
        {
            get { return Fields.LogoBmp[this]; }
            set { Fields.LogoBmp[this] = value; }
        }

        [DisplayName("Xconnect On"), Column("XCONNECT_ON"), Size(1)]
        public String XconnectOn
        {
            get { return Fields.XconnectOn[this]; }
            set { Fields.XconnectOn[this] = value; }
        }

        [DisplayName("Uload Path"), Column("ULOAD_PATH"), Size(30)]
        public String UloadPath
        {
            get { return Fields.UloadPath[this]; }
            set { Fields.UloadPath[this] = value; }
        }

        [DisplayName("Uload Batch No"), Column("ULOAD_BATCH_NO"), Size(8)]
        public Decimal? UloadBatchNo
        {
            get { return Fields.UloadBatchNo[this]; }
            set { Fields.UloadBatchNo[this] = value; }
        }

        [DisplayName("Dload Path"), Column("DLOAD_PATH"), Size(30)]
        public String DloadPath
        {
            get { return Fields.DloadPath[this]; }
            set { Fields.DloadPath[this] = value; }
        }

        [DisplayName("Dload Batch No"), Column("DLOAD_BATCH_NO"), Size(8)]
        public Decimal? DloadBatchNo
        {
            get { return Fields.DloadBatchNo[this]; }
            set { Fields.DloadBatchNo[this] = value; }
        }

        [DisplayName("Dload Recnum"), Column("DLOAD_RECNUM"), Size(8)]
        public Decimal? DloadRecnum
        {
            get { return Fields.DloadRecnum[this]; }
            set { Fields.DloadRecnum[this] = value; }
        }

        [DisplayName("Dload Command"), Column("DLOAD_COMMAND"), Size(128)]
        public String DloadCommand
        {
            get { return Fields.DloadCommand[this]; }
            set { Fields.DloadCommand[this] = value; }
        }

        [DisplayName("Uload Command"), Column("ULOAD_COMMAND"), Size(128)]
        public String UloadCommand
        {
            get { return Fields.UloadCommand[this]; }
            set { Fields.UloadCommand[this] = value; }
        }

        [DisplayName("Company Code"), Column("COMPANY_CODE"), Size(10)]
        public String CompanyCode
        {
            get { return Fields.CompanyCode[this]; }
            set { Fields.CompanyCode[this] = value; }
        }

        [DisplayName("With Btob"), Column("WITH_BTOB"), Size(1)]
        public String WithBtob
        {
            get { return Fields.WithBtob[this]; }
            set { Fields.WithBtob[this] = value; }
        }

        [DisplayName("With Ims"), Column("WITH_IMS"), Size(1)]
        public String WithIms
        {
            get { return Fields.WithIms[this]; }
            set { Fields.WithIms[this] = value; }
        }

        [DisplayName("Line No Entry"), Column("LINE_NO_ENTRY"), Size(1)]
        public String LineNoEntry
        {
            get { return Fields.LineNoEntry[this]; }
            set { Fields.LineNoEntry[this] = value; }
        }

        [DisplayName("Acct Itm Subcon"), Column("ACCT_ITM_SUBCON"), Size(30)]
        public String AcctItmSubcon
        {
            get { return Fields.AcctItmSubcon[this]; }
            set { Fields.AcctItmSubcon[this] = value; }
        }

        [DisplayName("With Accpac"), Column("WITH_ACCPAC"), Size(1)]
        public String WithAccpac
        {
            get { return Fields.WithAccpac[this]; }
            set { Fields.WithAccpac[this] = value; }
        }

        [DisplayName("Accpac Igrp"), Column("ACCPAC_IGRP"), Size(1)]
        public String AccpacIgrp
        {
            get { return Fields.AccpacIgrp[this]; }
            set { Fields.AccpacIgrp[this] = value; }
        }

        [DisplayName("Sale Anlys Int"), Column("SALE_ANLYS_INT"), Size(1)]
        public String SaleAnlysInt
        {
            get { return Fields.SaleAnlysInt[this]; }
            set { Fields.SaleAnlysInt[this] = value; }
        }

        [DisplayName("Purc Anlys Int"), Column("PURC_ANLYS_INT"), Size(1)]
        public String PurcAnlysInt
        {
            get { return Fields.PurcAnlysInt[this]; }
            set { Fields.PurcAnlysInt[this] = value; }
        }

        [DisplayName("Prod Anlys Int"), Column("PROD_ANLYS_INT"), Size(1)]
        public String ProdAnlysInt
        {
            get { return Fields.ProdAnlysInt[this]; }
            set { Fields.ProdAnlysInt[this] = value; }
        }

        [DisplayName("Mvmt Anlys Int"), Column("MVMT_ANLYS_INT"), Size(1)]
        public String MvmtAnlysInt
        {
            get { return Fields.MvmtAnlysInt[this]; }
            set { Fields.MvmtAnlysInt[this] = value; }
        }

        [DisplayName("Anlys Cat1"), Column("ANLYS_CAT1"), Size(30)]
        public String AnlysCat1
        {
            get { return Fields.AnlysCat1[this]; }
            set { Fields.AnlysCat1[this] = value; }
        }

        [DisplayName("Anlys Cat2"), Column("ANLYS_CAT2"), Size(30)]
        public String AnlysCat2
        {
            get { return Fields.AnlysCat2[this]; }
            set { Fields.AnlysCat2[this] = value; }
        }

        [DisplayName("Anlys Cat3"), Column("ANLYS_CAT3"), Size(30)]
        public String AnlysCat3
        {
            get { return Fields.AnlysCat3[this]; }
            set { Fields.AnlysCat3[this] = value; }
        }

        [DisplayName("Anlys Cat4"), Column("ANLYS_CAT4"), Size(30)]
        public String AnlysCat4
        {
            get { return Fields.AnlysCat4[this]; }
            set { Fields.AnlysCat4[this] = value; }
        }

        [DisplayName("Anlys Int"), Column("ANLYS_INT"), Size(1)]
        public String AnlysInt
        {
            get { return Fields.AnlysInt[this]; }
            set { Fields.AnlysInt[this] = value; }
        }

        [DisplayName("Itm No Grid Len"), Column("ITM_NO_GRID_LEN"), Size(4)]
        public Decimal? ItmNoGridLen
        {
            get { return Fields.ItmNoGridLen[this]; }
            set { Fields.ItmNoGridLen[this] = value; }
        }

        [DisplayName("Bom No Grid Len"), Column("BOM_NO_GRID_LEN"), Size(4)]
        public Decimal? BomNoGridLen
        {
            get { return Fields.BomNoGridLen[this]; }
            set { Fields.BomNoGridLen[this] = value; }
        }

        [DisplayName("Enable Lot"), Column("ENABLE_LOT"), Size(1), NotNull]
        public String EnableLot
        {
            get { return Fields.EnableLot[this]; }
            set { Fields.EnableLot[this] = value; }
        }

        [DisplayName("Enable Serial"), Column("ENABLE_SERIAL"), Size(1), NotNull]
        public String EnableSerial
        {
            get { return Fields.EnableSerial[this]; }
            set { Fields.EnableSerial[this] = value; }
        }

        [DisplayName("Lot No Length"), Column("LOT_NO_LENGTH"), Size(2)]
        public Decimal? LotNoLength
        {
            get { return Fields.LotNoLength[this]; }
            set { Fields.LotNoLength[this] = value; }
        }

        [DisplayName("Serial No Length"), Column("SERIAL_NO_LENGTH"), Size(2)]
        public Decimal? SerialNoLength
        {
            get { return Fields.SerialNoLength[this]; }
            set { Fields.SerialNoLength[this] = value; }
        }

        [DisplayName("Next Lot No"), Column("NEXT_LOT_NO"), Size(28)]
        public Decimal? NextLotNo
        {
            get { return Fields.NextLotNo[this]; }
            set { Fields.NextLotNo[this] = value; }
        }

        [DisplayName("Next Serial No"), Column("NEXT_SERIAL_NO"), Size(28)]
        public Decimal? NextSerialNo
        {
            get { return Fields.NextSerialNo[this]; }
            set { Fields.NextSerialNo[this] = value; }
        }

        [DisplayName("Max Lot Size"), Column("MAX_LOT_SIZE"), Size(14), Scale(4)]
        public Decimal? MaxLotSize
        {
            get { return Fields.MaxLotSize[this]; }
            set { Fields.MaxLotSize[this] = value; }
        }

        [DisplayName("Lot No Prefix"), Column("LOT_NO_PREFIX"), Size(30)]
        public String LotNoPrefix
        {
            get { return Fields.LotNoPrefix[this]; }
            set { Fields.LotNoPrefix[this] = value; }
        }

        [DisplayName("Serial No Prefix"), Column("SERIAL_NO_PREFIX"), Size(40)]
        public String SerialNoPrefix
        {
            get { return Fields.SerialNoPrefix[this]; }
            set { Fields.SerialNoPrefix[this] = value; }
        }

        [DisplayName("With Lot"), Column("WITH_LOT"), Size(1), NotNull]
        public String WithLot
        {
            get { return Fields.WithLot[this]; }
            set { Fields.WithLot[this] = value; }
        }

        [DisplayName("Itm No Len"), Column("ITM_NO_LEN"), Size(2)]
        public Decimal? ItmNoLen
        {
            get { return Fields.ItmNoLen[this]; }
            set { Fields.ItmNoLen[this] = value; }
        }

        [DisplayName("Record Lock"), Column("RECORD_LOCK"), Size(1)]
        public String RecordLock
        {
            get { return Fields.RecordLock[this]; }
            set { Fields.RecordLock[this] = value; }
        }

        [DisplayName("User Log"), Column("USER_LOG"), Size(1)]
        public String UserLog
        {
            get { return Fields.UserLog[this]; }
            set { Fields.UserLog[this] = value; }
        }

        [DisplayName("Scale Price"), Column("SCALE_PRICE"), Size(2)]
        public Decimal? ScalePrice
        {
            get { return Fields.ScalePrice[this]; }
            set { Fields.ScalePrice[this] = value; }
        }

        [DisplayName("Neg Stock"), Column("NEG_STOCK"), Size(1)]
        public String NegStock
        {
            get { return Fields.NegStock[this]; }
            set { Fields.NegStock[this] = value; }
        }

        [DisplayName("With Sql Attm"), Column("WITH_SQL_ATTM"), Size(1)]
        public String WithSqlAttm
        {
            get { return Fields.WithSqlAttm[this]; }
            set { Fields.WithSqlAttm[this] = value; }
        }

        [DisplayName("With Reset Lot"), Column("WITH_RESET_LOT"), Size(1)]
        public String WithResetLot
        {
            get { return Fields.WithResetLot[this]; }
            set { Fields.WithResetLot[this] = value; }
        }

        [DisplayName("With Reset Serial"), Column("WITH_RESET_SERIAL"), Size(1)]
        public String WithResetSerial
        {
            get { return Fields.WithResetSerial[this]; }
            set { Fields.WithResetSerial[this] = value; }
        }

        [DisplayName("Prev Reset Lot Date"), Column("PREV_RESET_LOT_DATE")]
        public DateTime? PrevResetLotDate
        {
            get { return Fields.PrevResetLotDate[this]; }
            set { Fields.PrevResetLotDate[this] = value; }
        }

        [DisplayName("Prev Reset Serial Date"), Column("PREV_RESET_SERIAL_DATE")]
        public DateTime? PrevResetSerialDate
        {
            get { return Fields.PrevResetSerialDate[this]; }
            set { Fields.PrevResetSerialDate[this] = value; }
        }

        [DisplayName("Anlys Cat5"), Column("ANLYS_CAT5"), Size(30)]
        public String AnlysCat5
        {
            get { return Fields.AnlysCat5[this]; }
            set { Fields.AnlysCat5[this] = value; }
        }

        [DisplayName("Anlys Cat6"), Column("ANLYS_CAT6"), Size(30)]
        public String AnlysCat6
        {
            get { return Fields.AnlysCat6[this]; }
            set { Fields.AnlysCat6[this] = value; }
        }

        [DisplayName("Anlys Cat7"), Column("ANLYS_CAT7"), Size(30)]
        public String AnlysCat7
        {
            get { return Fields.AnlysCat7[this]; }
            set { Fields.AnlysCat7[this] = value; }
        }

        [DisplayName("Anlys Cat8"), Column("ANLYS_CAT8"), Size(30)]
        public String AnlysCat8
        {
            get { return Fields.AnlysCat8[this]; }
            set { Fields.AnlysCat8[this] = value; }
        }

        [DisplayName("Anlys Cat9"), Column("ANLYS_CAT9"), Size(30)]
        public String AnlysCat9
        {
            get { return Fields.AnlysCat9[this]; }
            set { Fields.AnlysCat9[this] = value; }
        }

        [DisplayName("Anlys Cat10"), Column("ANLYS_CAT10"), Size(30)]
        public String AnlysCat10
        {
            get { return Fields.AnlysCat10[this]; }
            set { Fields.AnlysCat10[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 1"), Column("COST_SHEET_TAB_DESCRIPTION_1"), Size(30)]
        public String CostSheetTabDescription1
        {
            get { return Fields.CostSheetTabDescription1[this]; }
            set { Fields.CostSheetTabDescription1[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 2"), Column("COST_SHEET_TAB_DESCRIPTION_2"), Size(30)]
        public String CostSheetTabDescription2
        {
            get { return Fields.CostSheetTabDescription2[this]; }
            set { Fields.CostSheetTabDescription2[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 3"), Column("COST_SHEET_TAB_DESCRIPTION_3"), Size(30)]
        public String CostSheetTabDescription3
        {
            get { return Fields.CostSheetTabDescription3[this]; }
            set { Fields.CostSheetTabDescription3[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 4"), Column("COST_SHEET_TAB_DESCRIPTION_4"), Size(30)]
        public String CostSheetTabDescription4
        {
            get { return Fields.CostSheetTabDescription4[this]; }
            set { Fields.CostSheetTabDescription4[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 5"), Column("COST_SHEET_TAB_DESCRIPTION_5"), Size(30)]
        public String CostSheetTabDescription5
        {
            get { return Fields.CostSheetTabDescription5[this]; }
            set { Fields.CostSheetTabDescription5[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 6"), Column("COST_SHEET_TAB_DESCRIPTION_6"), Size(30)]
        public String CostSheetTabDescription6
        {
            get { return Fields.CostSheetTabDescription6[this]; }
            set { Fields.CostSheetTabDescription6[this] = value; }
        }

        [DisplayName("Cost Sheet Tab Description 7"), Column("COST_SHEET_TAB_DESCRIPTION_7"), Size(30)]
        public String CostSheetTabDescription7
        {
            get { return Fields.CostSheetTabDescription7[this]; }
            set { Fields.CostSheetTabDescription7[this] = value; }
        }

        [DisplayName("Acct Ar Temp"), Column("ACCT_AR_TEMP"), Size(30)]
        public String AcctArTemp
        {
            get { return Fields.AcctArTemp[this]; }
            set { Fields.AcctArTemp[this] = value; }
        }

        [DisplayName("Acct Ap Temp"), Column("ACCT_AP_TEMP"), Size(30)]
        public String AcctApTemp
        {
            get { return Fields.AcctApTemp[this]; }
            set { Fields.AcctApTemp[this] = value; }
        }

        [DisplayName("Plan Ord Def Last Po Price"), Column("PLAN_ORD_DEF_LAST_PO_PRICE")]
        public Boolean? PlanOrdDefLastPoPrice
        {
            get { return Fields.PlanOrdDefLastPoPrice[this]; }
            set { Fields.PlanOrdDefLastPoPrice[this] = value; }
        }

        [DisplayName("Portal Url"), Column("PORTAL_URL"), Size(100)]
        public String PortalUrl
        {
            get { return Fields.PortalUrl[this]; }
            set { Fields.PortalUrl[this] = value; }
        }

        [DisplayName("Kayue Next Po No"), Column("KAYUE_NEXT_PO_NO"), Size(6)]
        public Decimal? KayueNextPoNo
        {
            get { return Fields.KayueNextPoNo[this]; }
            set { Fields.KayueNextPoNo[this] = value; }
        }

        [DisplayName("Lot No Udf Label 01"), Column("LOT_NO_UDF_LABEL_01"), Size(50)]
        public String LotNoUdfLabel01
        {
            get { return Fields.LotNoUdfLabel01[this]; }
            set { Fields.LotNoUdfLabel01[this] = value; }
        }

        [DisplayName("Lot No Udf Label 02"), Column("LOT_NO_UDF_LABEL_02"), Size(50)]
        public String LotNoUdfLabel02
        {
            get { return Fields.LotNoUdfLabel02[this]; }
            set { Fields.LotNoUdfLabel02[this] = value; }
        }

        [DisplayName("Lot No Udf Label 03"), Column("LOT_NO_UDF_LABEL_03"), Size(50)]
        public String LotNoUdfLabel03
        {
            get { return Fields.LotNoUdfLabel03[this]; }
            set { Fields.LotNoUdfLabel03[this] = value; }
        }

        [DisplayName("Lot No Udf Label 04"), Column("LOT_NO_UDF_LABEL_04"), Size(50)]
        public String LotNoUdfLabel04
        {
            get { return Fields.LotNoUdfLabel04[this]; }
            set { Fields.LotNoUdfLabel04[this] = value; }
        }

        [DisplayName("Lot No Udf Label 05"), Column("LOT_NO_UDF_LABEL_05"), Size(50)]
        public String LotNoUdfLabel05
        {
            get { return Fields.LotNoUdfLabel05[this]; }
            set { Fields.LotNoUdfLabel05[this] = value; }
        }

        [DisplayName("Bsc Po Over Budget Password"), Column("BSC_PO_OVER_BUDGET_PASSWORD"), Size(32)]
        public String BscPoOverBudgetPassword
        {
            get { return Fields.BscPoOverBudgetPassword[this]; }
            set { Fields.BscPoOverBudgetPassword[this] = value; }
        }

        [DisplayName("Acct Ar Deposit"), Column("ACCT_AR_DEPOSIT"), Size(30)]
        public String AcctArDeposit
        {
            get { return Fields.AcctArDeposit[this]; }
            set { Fields.AcctArDeposit[this] = value; }
        }

        [DisplayName("Acct Ap Deposit"), Column("ACCT_AP_DEPOSIT"), Size(30)]
        public String AcctApDeposit
        {
            get { return Fields.AcctApDeposit[this]; }
            set { Fields.AcctApDeposit[this] = value; }
        }

        [DisplayName("With Server Attm"), Column("WITH_SERVER_ATTM"), Size(1)]
        public String WithServerAttm
        {
            get { return Fields.WithServerAttm[this]; }
            set { Fields.WithServerAttm[this] = value; }
        }

        [DisplayName("Ftp Host"), Column("FTP_HOST"), Size(20)]
        public String FtpHost
        {
            get { return Fields.FtpHost[this]; }
            set { Fields.FtpHost[this] = value; }
        }

        [DisplayName("Ftp User Id"), Column("FTP_USER_ID"), Size(20)]
        public String FtpUserId
        {
            get { return Fields.FtpUserId[this]; }
            set { Fields.FtpUserId[this] = value; }
        }

        [DisplayName("Ftp Password"), Column("FTP_PASSWORD"), Size(20)]
        public String FtpPassword
        {
            get { return Fields.FtpPassword[this]; }
            set { Fields.FtpPassword[this] = value; }
        }

        [DisplayName("Ftp Name Pattern"), Column("FTP_NAME_PATTERN"), Size(200)]
        public String FtpNamePattern
        {
            get { return Fields.FtpNamePattern[this]; }
            set { Fields.FtpNamePattern[this] = value; }
        }

        [DisplayName("Implement Uom Uppercase"), Column("IMPLEMENT_UOM_UPPERCASE"), Size(1)]
        public String ImplementUomUppercase
        {
            get { return Fields.ImplementUomUppercase[this]; }
            set { Fields.ImplementUomUppercase[this] = value; }
        }

        [DisplayName("Integrated Email With Msssage Box"), Column("INTEGRATED_EMAIL_WITH_MSSSAGE_BOX"), Size(1)]
        public String IntegratedEmailWithMsssageBox
        {
            get { return Fields.IntegratedEmailWithMsssageBox[this]; }
            set { Fields.IntegratedEmailWithMsssageBox[this] = value; }
        }

        [DisplayName("Cfg"), Column("CFG")]
        public String Cfg
        {
            get { return Fields.Cfg[this]; }
            set { Fields.Cfg[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanyParameterRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CompanyName;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField PostCode;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField Email;
            public StringField TaxAcctNo;
            public StringField BusRegNo;
            public DateTimeField DrevisedDate;
            public StringField DrevisedBy;
            public StringField BranchNo;
            public StringField BaseCurrency;
            public DecimalField NoOfPeriods;
            public StringField CurrentPeriod;
            public StringField OpenPrdFrom;
            public StringField OpenPrdTo;
            public StringField AllowEntries;
            public StringField AcctRetEarn;
            public StringField AcctCurEarn;
            public StringField AcctEndBs;
            public StringField LocReceiving;
            public StringField LocShipment;
            public StringField LocPos;
            public StringField LocMaterial;
            public StringField LocProduce;
            public StringField IcRevaluation;
            public StringField FgStdCosting;
            public StringField AllocMethod;
            public StringField CostingMethod;
            public StringField AllowLotOpt;
            public StringField PmntFundCode;
            public StringField RcptFundCode;
            public StringField SalesPayTerms;
            public StringField PurchPayTerms;
            public StringField ItemGroup;
            public StringField CustomerGroup;
            public StringField VendorGroup;
            public StringField SlCgtaxCode;
            public StringField SlCltaxCode;
            public StringField SlVgtaxCode;
            public StringField SlVltaxCode;
            public StringField SlItaxCode;
            public StringField PuCgtaxCode;
            public StringField PuCltaxCode;
            public StringField PuVgtaxCode;
            public StringField PuVltaxCode;
            public StringField PuItaxCode;
            public StringField WithTaxation;
            public StringField ProcSalesGtax;
            public StringField ProcSalesLtax;
            public StringField ProcPurchGtax;
            public StringField ProcPurchLtax;
            public DateTimeField TrevisedDate;
            public StringField TrevisedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField AltName;
            public StringField AltAddress;
            public StringField AltAddress2;
            public StringField AltAddress3;
            public StringField AltAddress4;
            public StringField MainBranPath;
            public DecimalField MainBranCount;
            public StringField OnlineBranUpd;
            public StringField WithCostCtr;
            public StringField WithDept;
            public StringField WithBinCtrl;
            public StringField WithInspection;
            public StringField AcctItmAsset;
            public StringField AcctItmWip;
            public StringField AcctItmConsum;
            public StringField AcctItmScrap;
            public StringField AcctItmPvar;
            public StringField AcctItmReval;
            public StringField AcctItmVaria;
            public StringField AcctItmSales;
            public StringField AcctItmSlret;
            public StringField AcctItmSldisc;
            public StringField AcctItmCogs;
            public StringField AcctItmPurch;
            public StringField AcctItmPuret;
            public StringField AcctItmPudisc;
            public StringField AcctItmPutax;
            public StringField AcctMvtIssue;
            public StringField AcctMvtRcpt;
            public StringField AcctMvtAdj;
            public StringField AcctSlsMisc;
            public StringField AcctSlsMscret;
            public StringField AcctSlsTrdisc;
            public StringField AcctSlsLntax;
            public StringField AcctSlsGrtax;
            public StringField AcctPurMisc;
            public StringField AcctPurMscret;
            public StringField AcctPurTrdisc;
            public StringField AcctPurGrtax;
            public StringField AcctArCash;
            public StringField AcctArCust;
            public StringField AcctArDisc;
            public StringField AcctArAdj;
            public StringField AcctArForex;
            public StringField AcctApCash;
            public StringField AcctApVend;
            public StringField AcctApDisc;
            public StringField AcctApAdj;
            public StringField AcctApForex;
            public StringField AcctApVaria;
            public StringField AcctMachine;
            public StringField AcctEnergy;
            public StringField AcctWater;
            public StringField AcctRental;
            public StringField AcctLabor;
            public StringField AcctInlab;
            public StringField AcctInmat;
            public StringField AcctMisc;
            public StringField AcctSuspAr;
            public StringField AcctSuspAp;
            public StringField AcctSuspIc;
            public StringField AcctSuspPr;
            public StringField AcctSuspFa;
            public StringField AcctSuspSub;
            public StringField AcctSuspIncom;
            public StringField AcctSuspExpen;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public DateTimeField BrevisedDate;
            public StringField BrevisedBy;
            public StringField DeptProd;
            public StringField DeptSales;
            public StringField DeptPurch;
            public DecimalField NoOfShift;
            public DecimalField Shift1Hrs;
            public DecimalField Shift2Hrs;
            public DecimalField Shift3Hrs;
            public StringField Shift1Start;
            public StringField Shift2Start;
            public StringField Shift3Start;
            public DecimalField FirstWeekDay;
            public StringField CanReceive1;
            public StringField CanReceive2;
            public StringField CanReceive3;
            public StringField CanReceive4;
            public StringField CanReceive5;
            public StringField CanReceive6;
            public StringField CanReceive7;
            public StringField CanShip1;
            public StringField CanShip2;
            public StringField CanShip3;
            public StringField CanShip4;
            public StringField CanShip5;
            public StringField CanShip6;
            public StringField CanShip7;
            public StringField IsHoliday1;
            public StringField IsHoliday2;
            public StringField IsHoliday3;
            public StringField IsHoliday4;
            public StringField IsHoliday5;
            public StringField IsHoliday6;
            public StringField IsHoliday7;
            public StringField HalfDay1;
            public StringField HalfDay2;
            public StringField HalfDay3;
            public StringField HalfDay4;
            public StringField HalfDay5;
            public StringField HalfDay6;
            public StringField HalfDay7;
            public DateTimeField CrevisedDate;
            public StringField CrevisedBy;
            public DecimalField LogNoShip;
            public DecimalField LogNoDlry;
            public DecimalField LogNoMvmt;
            public DecimalField LogNoArOpen;
            public DecimalField LogNoApOpen;
            public DecimalField LogNoLedg;
            public DecimalField InvtCostAvail;
            public DecimalField InvtCostLdg;
            public DecimalField OnSalesCount;
            public DecimalField OnPurchCount;
            public DecimalField OnJobCount;
            public DecimalField ArInvoAmtBal;
            public DecimalField ArOpenAmtBal;
            public DecimalField ArNetAmtBal;
            public DecimalField ApInvoAmtBal;
            public DecimalField ApOpenAmtBal;
            public DecimalField ApNetAmtBal;
            public BooleanField VerifySettings;
            public StringField LogoBmp;
            public StringField XconnectOn;
            public StringField UloadPath;
            public DecimalField UloadBatchNo;
            public StringField DloadPath;
            public DecimalField DloadBatchNo;
            public DecimalField DloadRecnum;
            public StringField DloadCommand;
            public StringField UloadCommand;
            public StringField CompanyCode;
            public StringField WithBtob;
            public StringField WithIms;
            public StringField LineNoEntry;
            public StringField AcctItmSubcon;
            public StringField WithAccpac;
            public StringField AccpacIgrp;
            public StringField SaleAnlysInt;
            public StringField PurcAnlysInt;
            public StringField ProdAnlysInt;
            public StringField MvmtAnlysInt;
            public StringField AnlysCat1;
            public StringField AnlysCat2;
            public StringField AnlysCat3;
            public StringField AnlysCat4;
            public StringField AnlysInt;
            public DecimalField ItmNoGridLen;
            public DecimalField BomNoGridLen;
            public StringField EnableLot;
            public StringField EnableSerial;
            public DecimalField LotNoLength;
            public DecimalField SerialNoLength;
            public DecimalField NextLotNo;
            public DecimalField NextSerialNo;
            public DecimalField MaxLotSize;
            public StringField LotNoPrefix;
            public StringField SerialNoPrefix;
            public StringField WithLot;
            public DecimalField ItmNoLen;
            public StringField RecordLock;
            public StringField UserLog;
            public DecimalField ScalePrice;
            public StringField NegStock;
            public StringField WithSqlAttm;
            public StringField WithResetLot;
            public StringField WithResetSerial;
            public DateTimeField PrevResetLotDate;
            public DateTimeField PrevResetSerialDate;
            public StringField AnlysCat5;
            public StringField AnlysCat6;
            public StringField AnlysCat7;
            public StringField AnlysCat8;
            public StringField AnlysCat9;
            public StringField AnlysCat10;
            public StringField CostSheetTabDescription1;
            public StringField CostSheetTabDescription2;
            public StringField CostSheetTabDescription3;
            public StringField CostSheetTabDescription4;
            public StringField CostSheetTabDescription5;
            public StringField CostSheetTabDescription6;
            public StringField CostSheetTabDescription7;
            public StringField AcctArTemp;
            public StringField AcctApTemp;
            public BooleanField PlanOrdDefLastPoPrice;
            public StringField PortalUrl;
            public DecimalField KayueNextPoNo;
            public StringField LotNoUdfLabel01;
            public StringField LotNoUdfLabel02;
            public StringField LotNoUdfLabel03;
            public StringField LotNoUdfLabel04;
            public StringField LotNoUdfLabel05;
            public StringField BscPoOverBudgetPassword;
            public StringField AcctArDeposit;
            public StringField AcctApDeposit;
            public StringField WithServerAttm;
            public StringField FtpHost;
            public StringField FtpUserId;
            public StringField FtpPassword;
            public StringField FtpNamePattern;
            public StringField ImplementUomUppercase;
            public StringField IntegratedEmailWithMsssageBox;
            public StringField Cfg;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "BasicInformation.CompanyParameter";
            }
        }
    }
}
