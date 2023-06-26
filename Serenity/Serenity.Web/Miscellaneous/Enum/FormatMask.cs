#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FormatMask.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FormatMask
    {
        [StringValue("<ORDERNO>")]
        [DisplayText("Order No.")]
        OrderNo,

        [StringValue("<ITEM>")]
        [DisplayText("Item No.")]
        ItemNo,

        [StringValue("<CUSTITEM>")]
        [DisplayText("Cust. Item No.")]
        CustomerItemNo,

        [StringValue("<QTY>")]
        [DisplayText("Qty")]
        TotalQty,

        [StringValue("<QTY/CTN>")]
        [DisplayText("Qty / Ctn.")]
        QtyPerCtn,

        [StringValue("<NUM/CTN>")]
        [DisplayText("Number of Ctn.")]
        NumberOfCtn,

        [StringValue("<CTNFROM>")]
        [DisplayText("Ctn. From")]
        CtnFrom,

        [StringValue("<CTNTO>")]
        [DisplayText("Ctn To")]
        CtnTo,

        [StringValue("<GW/CTN>")]
        [DisplayText("Gross Weight / Ctn.")]
        GrossWtPerCtn,

        [StringValue("<GW/TOTAL>")]
        [DisplayText("Total Gross Weight")]
        TotalGrossWt,

        [StringValue("<NW/CTN>")]
        [DisplayText("Net Weight / Ctn.")]
        NetWtPerCtn,

        [StringValue("<WT/UOM>")]
        [DisplayText("Weight Uom")]
        WeightUom,

        [StringValue("<DIMENSION>")]
        [DisplayText("Dimension / Ctn.")]
        DimensionPerCtn,

        [StringValue("<VOL/CTN>")]
        [DisplayText("Volume / Ctn.")]
        VolumePerCtn,

        [StringValue("<VOL/TOTAL>")]
        [DisplayText("Total Volume")]
        TotalVolume,

        [StringValue("<DIMENSION/UOM>")]
        [DisplayText("Dimension Uom")]
        DimensionUom,

        [StringValue("<QTY/PACK>")]
        [DisplayText("Qty / Pack")]
        InnerQtyPerPack,
        [StringValue("<CUSTNO>")]
        [DisplayText("Customer no")]
        CustomerNo,
        [StringValue("<CUSTNAME>")]
        [DisplayText("Customer Name")]
        CustomerName,
        [StringValue("<CUSTPO>")]
        [DisplayText("Customer P.O. No.")]
        CustomerPONo,
        [StringValue("<SHIPTO>")]
        [DisplayText("Ship To")]
        ShipTo,
        [StringValue("<CUSTADDR1>")]
        [DisplayText("Customer Address 1")]
        CustomerAddress1,
        [StringValue("<CUSTADDR2>")]
        [DisplayText("Customer Address 2")]
        CustomerAddress2,
        [StringValue("<CUSTADDR3>")]
        [DisplayText("Customer Address 3")]
        CustomerAddress3,
        [StringValue("<CUSTADDR4>")]
        [DisplayText("Customer Address 4")]
        CustomerAddress4,
        [StringValue("<SHIPVIA>")]
        [DisplayText("Ship Via")]
        ShipVia,
        [StringValue("<SHIPTERMS>")]
        [DisplayText("Shipment terms")]
        ShipmentTerms,
        [StringValue("<ANLYS1>")]
        [DisplayText("Analysis Code 1")]
        AnalysisCode1,
        [StringValue("<ANLYS2>")]
        [DisplayText("Analysis Code 2")]
        AnalysisCode2,
        [StringValue("<SHORTNAME>")]
        [DisplayText("Customer Short Name")]
        CustomerShortName,
        [StringValue("<DESC>")]
        [DisplayText("Item Description")]
        ItemDescription,
        [StringValue("<SUBPO>")]
        [DisplayText("Sub PO")]
        SubPO,
        [StringValue("<KITEM>")]
        [DisplayText("Splitted Item No. with using Alphabetic char (A-Z)")]
        SplittedItemNo,
        [StringValue("<RMK>")]
        [DisplayText("Ship Mark Remark")]
        ShipmarkRemark,
        [StringValue("<UPC>")]
        [DisplayText("UPC No.")]
        UPC
    }
}
