#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LocationRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBLOCN]")]
    [DisplayName("Location"), InstanceName("Location"), TwoLevelCached]
    [LookupScript("MasterData.LocationRow")]
    public sealed class LocationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), PrimaryKey, QuickSearch]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Address"), Column("ADDRESS"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Address2"), Column("ADDRESS2"), Size(50)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName("Address3"), Column("ADDRESS3"), Size(50)]
        public String Address3
        {
            get { return Fields.Address3[this]; }
            set { Fields.Address3[this] = value; }
        }

        [DisplayName("Address4"), Column("ADDRESS4"), Size(50)]
        public String Address4
        {
            get { return Fields.Address4[this]; }
            set { Fields.Address4[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4), NotNull]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("No Reservation"), Column("NO_RESERVATION"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? NoReservation
        {
            get { return Fields.NoReservation[this]; }
            set { Fields.NoReservation[this] = value; }
        }

        [DisplayName("No Waitlist"), Column("NO_WAITLIST"), Size(1)]
        [BoolStringConverter]
        public bool? NoWaitlist
        {
            get { return Fields.NoWaitlist[this]; }
            set { Fields.NoWaitlist[this] = value; }
        }

        [DisplayName("No Available"), Column("NO_AVAILABLE"), Size(1)]
        [BoolStringConverter]
        public bool? NoAvailable
        {
            get { return Fields.NoAvailable[this]; }
            set { Fields.NoAvailable[this] = value; }
        }

        [DisplayName("No Planning"), Column("NO_PLANNING"), Size(1)]
        [BoolStringConverter]
        public bool? NoPlanning
        {
            get { return Fields.NoPlanning[this]; }
            set { Fields.NoPlanning[this] = value; }
        }

        [DisplayName("No Issuance"), Column("NO_ISSUANCE"), Size(1)]
        [BoolStringConverter]
        public bool? NoIssuance
        {
            get { return Fields.NoIssuance[this]; }
            set { Fields.NoIssuance[this] = value; }
        }

        [DisplayName("No Receipts"), Column("NO_RECEIPTS"), Size(1)]
        [BoolStringConverter]
        public bool? NoReceipts
        {
            get { return Fields.NoReceipts[this]; }
            set { Fields.NoReceipts[this] = value; }
        }

        [DisplayName("No Mat Issue"), Column("NO_MAT_ISSUE"), Size(1)]
        [BoolStringConverter]
        public bool? NoMatIssue
        {
            get { return Fields.NoMatIssue[this]; }
            set { Fields.NoMatIssue[this] = value; }
        }

        [DisplayName("No Fg Return"), Column("NO_FG_RETURN"), Size(1)]
        [BoolStringConverter]
        public bool? NoFgReturn
        {
            get { return Fields.NoFgReturn[this]; }
            set { Fields.NoFgReturn[this] = value; }
        }

        [DisplayName("No Shipment"), Column("NO_SHIPMENT"), Size(1)]
        [BoolStringConverter]
        public bool? NoShipment
        {
            get { return Fields.NoShipment[this]; }
            set { Fields.NoShipment[this] = value; }
        }

        [DisplayName("No Grn"), Column("NO_GRN"), Size(1)]
        [BoolStringConverter]
        public bool? NoGrn
        {
            get { return Fields.NoGrn[this]; }
            set { Fields.NoGrn[this] = value; }
        }

        [DisplayName("With Backlog"), Column("WITH_BACKLOG"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? WithBacklog
        {
            get { return Fields.WithBacklog[this]; }
            set { Fields.WithBacklog[this] = value; }
        }

        [DisplayName("On Sorder Count"), Column("ON_SORDER_COUNT"), Size(6)]
        public Decimal? OnSorderCount
        {
            get { return Fields.OnSorderCount[this]; }
            set { Fields.OnSorderCount[this] = value; }
        }

        [DisplayName("On Porder Count"), Column("ON_PORDER_COUNT"), Size(6)]
        public Decimal? OnPorderCount
        {
            get { return Fields.OnPorderCount[this]; }
            set { Fields.OnPorderCount[this] = value; }
        }

        [DisplayName("On Jorder Count"), Column("ON_JORDER_COUNT"), Size(6)]
        public Decimal? OnJorderCount
        {
            get { return Fields.OnJorderCount[this]; }
            set { Fields.OnJorderCount[this] = value; }
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

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
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

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("With Bin Ctrl"), Column("WITH_BIN_CTRL"), Size(1)]
        public String WithBinCtrl
        {
            get { return Fields.WithBinCtrl[this]; }
            set { Fields.WithBinCtrl[this] = value; }
        }

        [DisplayName("With Packing Box"), Column("WITH_PACKING_BOX")]
        public Boolean? WithPackingBox
        {
            get { return Fields.WithPackingBox[this]; }
            set { Fields.WithPackingBox[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Loc; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LocationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Loc;
            public StringField Description;
            public BooleanField Suspended;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField BranchNo;
            public BooleanField NoReservation;
            public BooleanField NoWaitlist;
            public BooleanField NoAvailable;
            public BooleanField NoPlanning;
            public BooleanField NoIssuance;
            public BooleanField NoReceipts;
            public BooleanField NoMatIssue;
            public BooleanField NoFgReturn;
            public BooleanField NoShipment;
            public BooleanField NoGrn;
            public BooleanField WithBacklog;
            public DecimalField OnSorderCount;
            public DecimalField OnPorderCount;
            public DecimalField OnJorderCount;
            public DecimalField InvtCostAvail;
            public DecimalField InvtCostLdg;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField WithBinCtrl;
            public BooleanField WithPackingBox;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Location";
            }
        }
    }
}
