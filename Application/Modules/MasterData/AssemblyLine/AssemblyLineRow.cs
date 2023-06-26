#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AssemblyLineRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBASML]")]
    [DisplayName("Assembly Line"), InstanceName("Assembly Line"), TwoLevelCached]   
    public sealed class AssemblyLineRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Assembly Line"), Column("ASSEMBLY_LINE"), Size(6), PrimaryKey, QuickSearch]
        public String AssemblyLine
        {
            get { return Fields.AssemblyLine[this]; }
            set { Fields.AssemblyLine[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4), NotNull]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Priority"), Column("PRIORITY"), Size(1)]
        public String Priority
        {
            get { return Fields.Priority[this]; }
            set { Fields.Priority[this] = value; }
        }

        [DisplayName("Effc Rating"), Column("EFFC_RATING"), Size(6), Scale(2)]
        public Decimal? EffcRating
        {
            get { return Fields.EffcRating[this]; }
            set { Fields.EffcRating[this] = value; }
        }

        [DisplayName("Restrict0"), Column("RESTRICT0"), Size(10)]
        public String Restrict0
        {
            get { return Fields.Restrict0[this]; }
            set { Fields.Restrict0[this] = value; }
        }

        [DisplayName("Restrict1"), Column("RESTRICT1"), Size(10)]
        public String Restrict1
        {
            get { return Fields.Restrict1[this]; }
            set { Fields.Restrict1[this] = value; }
        }

        [DisplayName("Restrict2"), Column("RESTRICT2"), Size(10)]
        public String Restrict2
        {
            get { return Fields.Restrict2[this]; }
            set { Fields.Restrict2[this] = value; }
        }

        [DisplayName("Restrict3"), Column("RESTRICT3"), Size(10)]
        public String Restrict3
        {
            get { return Fields.Restrict3[this]; }
            set { Fields.Restrict3[this] = value; }
        }

        [DisplayName("Restrict4"), Column("RESTRICT4"), Size(10)]
        public String Restrict4
        {
            get { return Fields.Restrict4[this]; }
            set { Fields.Restrict4[this] = value; }
        }

        [DisplayName("Restrict5"), Column("RESTRICT5"), Size(10)]
        public String Restrict5
        {
            get { return Fields.Restrict5[this]; }
            set { Fields.Restrict5[this] = value; }
        }

        [DisplayName("Restrict6"), Column("RESTRICT6"), Size(10)]
        public String Restrict6
        {
            get { return Fields.Restrict6[this]; }
            set { Fields.Restrict6[this] = value; }
        }

        [DisplayName("Restrict7"), Column("RESTRICT7"), Size(10)]
        public String Restrict7
        {
            get { return Fields.Restrict7[this]; }
            set { Fields.Restrict7[this] = value; }
        }

        [DisplayName("Restrict8"), Column("RESTRICT8"), Size(10)]
        public String Restrict8
        {
            get { return Fields.Restrict8[this]; }
            set { Fields.Restrict8[this] = value; }
        }

        [DisplayName("Restrict9"), Column("RESTRICT9"), Size(10)]
        public String Restrict9
        {
            get { return Fields.Restrict9[this]; }
            set { Fields.Restrict9[this] = value; }
        }

        [DisplayName("Require0"), Column("REQUIRE0"), Size(10)]
        public String Require0
        {
            get { return Fields.Require0[this]; }
            set { Fields.Require0[this] = value; }
        }

        [DisplayName("Require1"), Column("REQUIRE1"), Size(10)]
        public String Require1
        {
            get { return Fields.Require1[this]; }
            set { Fields.Require1[this] = value; }
        }

        [DisplayName("Require2"), Column("REQUIRE2"), Size(10)]
        public String Require2
        {
            get { return Fields.Require2[this]; }
            set { Fields.Require2[this] = value; }
        }

        [DisplayName("Require3"), Column("REQUIRE3"), Size(10)]
        public String Require3
        {
            get { return Fields.Require3[this]; }
            set { Fields.Require3[this] = value; }
        }

        [DisplayName("Require4"), Column("REQUIRE4"), Size(10)]
        public String Require4
        {
            get { return Fields.Require4[this]; }
            set { Fields.Require4[this] = value; }
        }

        [DisplayName("Require5"), Column("REQUIRE5"), Size(10)]
        public String Require5
        {
            get { return Fields.Require5[this]; }
            set { Fields.Require5[this] = value; }
        }

        [DisplayName("Require6"), Column("REQUIRE6"), Size(10)]
        public String Require6
        {
            get { return Fields.Require6[this]; }
            set { Fields.Require6[this] = value; }
        }

        [DisplayName("Require7"), Column("REQUIRE7"), Size(10)]
        public String Require7
        {
            get { return Fields.Require7[this]; }
            set { Fields.Require7[this] = value; }
        }

        [DisplayName("Require8"), Column("REQUIRE8"), Size(10)]
        public String Require8
        {
            get { return Fields.Require8[this]; }
            set { Fields.Require8[this] = value; }
        }

        [DisplayName("Require9"), Column("REQUIRE9"), Size(10)]
        public String Require9
        {
            get { return Fields.Require9[this]; }
            set { Fields.Require9[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.AssemblyLine; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        [MasterDetailRelation(foreignKey: "AssemblyLine")]
        [DisplayName("Detail List"), NotMapped]
        public List<AssemblyLineWorkCentreDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AssemblyLineRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<AssemblyLineWorkCentreDetailRow> DetailList;

            public DecimalField Recnum;
            public StringField AssemblyLine;
            public StringField Description;
            public StringField BranchNo;
            public BooleanField Suspended;
            public StringField Priority;
            public DecimalField EffcRating;
            public StringField Restrict0;
            public StringField Restrict1;
            public StringField Restrict2;
            public StringField Restrict3;
            public StringField Restrict4;
            public StringField Restrict5;
            public StringField Restrict6;
            public StringField Restrict7;
            public StringField Restrict8;
            public StringField Restrict9;
            public StringField Require0;
            public StringField Require1;
            public StringField Require2;
            public StringField Require3;
            public StringField Require4;
            public StringField Require5;
            public StringField Require6;
            public StringField Require7;
            public StringField Require8;
            public StringField Require9;
            public StringField AcctMachine;
            public StringField AcctEnergy;
            public StringField AcctWater;
            public StringField AcctRental;
            public StringField AcctLabor;
            public StringField AcctInlab;
            public StringField AcctInmat;
            public StringField AcctMisc;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField BrevisedDate;
            public StringField BrevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.AssemblyLine";
            }
        }
    }
}
