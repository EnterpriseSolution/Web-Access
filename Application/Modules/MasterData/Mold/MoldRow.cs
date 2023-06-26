#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MoldRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBMOLD]")]
    [DisplayName("Mold"), InstanceName("Mold"), TwoLevelCached]   
    public sealed class MoldRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Mold No"), Column("MOLD_NO"), Size(30), PrimaryKey, QuickSearch]
        public String MoldNo
        {
            get { return Fields.MoldNo[this]; }
            set { Fields.MoldNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Total Set"), Column("TOTAL_SET")]
        public Int32? TotalSet
        {
            get { return Fields.TotalSet[this]; }
            set { Fields.TotalSet[this] = value; }
        }

        [DisplayName("Std Output"), Column("STD_OUTPUT")]
        public Int32? StdOutput
        {
            get { return Fields.StdOutput[this]; }
            set { Fields.StdOutput[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Length"), Column("LENGTH"), Size(14), Scale(4)]
        public Decimal? Length
        {
            get { return Fields.Length[this]; }
            set { Fields.Length[this] = value; }
        }

        [DisplayName("Width"), Column("WIDTH"), Size(14), Scale(4)]
        public Decimal? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("Thickness"), Column("THICKNESS"), Size(14), Scale(4)]
        public Decimal? Thickness
        {
            get { return Fields.Thickness[this]; }
            set { Fields.Thickness[this] = value; }
        }

        [DisplayName("Weight"), Column("WEIGHT"), Size(14), Scale(4)]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("Set Weight"), Column("SET_WEIGHT"), Size(14), Scale(4)]
        public Decimal? SetWeight
        {
            get { return Fields.SetWeight[this]; }
            set { Fields.SetWeight[this] = value; }
        }

        [DisplayName("Shrink"), Column("SHRINK"), Size(14), Scale(4)]
        public Decimal? Shrink
        {
            get { return Fields.Shrink[this]; }
            set { Fields.Shrink[this] = value; }
        }

        [DisplayName("Shot Size"), Column("SHOT_SIZE"), Size(14), Scale(4)]
        public Decimal? ShotSize
        {
            get { return Fields.ShotSize[this]; }
            set { Fields.ShotSize[this] = value; }
        }

        [DisplayName("Cavity Finish"), Column("CAVITY_FINISH"), Size(30)]
        public String CavityFinish
        {
            get { return Fields.CavityFinish[this]; }
            set { Fields.CavityFinish[this] = value; }
        }

        [DisplayName("Temp Ctrl Zone"), Column("TEMP_CTRL_ZONE"), Size(14), Scale(4)]
        public Decimal? TempCtrlZone
        {
            get { return Fields.TempCtrlZone[this]; }
            set { Fields.TempCtrlZone[this] = value; }
        }

        [DisplayName("Wtr Flow A"), Column("WTR_FLOW_A"), Size(14), Scale(4)]
        public Decimal? WtrFlowA
        {
            get { return Fields.WtrFlowA[this]; }
            set { Fields.WtrFlowA[this] = value; }
        }

        [DisplayName("Wtr Flow B"), Column("WTR_FLOW_B"), Size(14), Scale(4)]
        public Decimal? WtrFlowB
        {
            get { return Fields.WtrFlowB[this]; }
            set { Fields.WtrFlowB[this] = value; }
        }

        [DisplayName("Qmc"), Column("QMC"), Size(1)]
        public String Qmc
        {
            get { return Fields.Qmc[this]; }
            set { Fields.Qmc[this] = value; }
        }

        [DisplayName("Hy Cores"), Column("HY_CORES"), Size(1)]
        public String HyCores
        {
            get { return Fields.HyCores[this]; }
            set { Fields.HyCores[this] = value; }
        }

        [DisplayName("Mold Cost"), Column("MOLD_COST"), Size(12), Scale(2)]
        public Decimal? MoldCost
        {
            get { return Fields.MoldCost[this]; }
            set { Fields.MoldCost[this] = value; }
        }

        [DisplayName("Ejector Rtn"), Column("EJECTOR_RTN"), Size(20)]
        public String EjectorRtn
        {
            get { return Fields.EjectorRtn[this]; }
            set { Fields.EjectorRtn[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(1073741823)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Picture File"), Column("PICTURE_FILE"), Size(255)]
        public String PictureFile
        {
            get { return Fields.PictureFile[this]; }
            set { Fields.PictureFile[this] = value; }
        }

        [DisplayName("Cav Sets"), Column("CAV_SETS")]
        public Int32? CavSets
        {
            get { return Fields.CavSets[this]; }
            set { Fields.CavSets[this] = value; }
        }

        [DisplayName("Cav Sq Inch"), Column("CAV_SQ_INCH")]
        public Int32? CavSqInch
        {
            get { return Fields.CavSqInch[this]; }
            set { Fields.CavSqInch[this] = value; }
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

        [DisplayName("Life Time"), Column("LIFE_TIME"), Size(10)]
        public Decimal? LifeTime
        {
            get { return Fields.LifeTime[this]; }
            set { Fields.LifeTime[this] = value; }
        }

        [DisplayName("Job Qty"), Column("JOB_QTY"), Size(10)]
        public Decimal? JobQty
        {
            get { return Fields.JobQty[this]; }
            set { Fields.JobQty[this] = value; }
        }

        [DisplayName("Fin Qty"), Column("FIN_QTY"), Size(10)]
        public Decimal? FinQty
        {
            get { return Fields.FinQty[this]; }
            set { Fields.FinQty[this] = value; }
        }

        [DisplayName("Bal Qty"), Column("BAL_QTY"), Size(10)]
        public Decimal? BalQty
        {
            get { return Fields.BalQty[this]; }
            set { Fields.BalQty[this] = value; }
        }

        [DisplayName("Rep Qty"), Column("REP_QTY"), Size(10)]
        public Decimal? RepQty
        {
            get { return Fields.RepQty[this]; }
            set { Fields.RepQty[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MoldNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MoldRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField MoldNo;
            public StringField Description;
            public Int32Field TotalSet;
            public Int32Field StdOutput;
            public StringField Suspended;
            public DecimalField Length;
            public DecimalField Width;
            public DecimalField Thickness;
            public DecimalField Weight;
            public DecimalField SetWeight;
            public DecimalField Shrink;
            public DecimalField ShotSize;
            public StringField CavityFinish;
            public DecimalField TempCtrlZone;
            public DecimalField WtrFlowA;
            public DecimalField WtrFlowB;
            public StringField Qmc;
            public StringField HyCores;
            public DecimalField MoldCost;
            public StringField EjectorRtn;
            public StringField Remarks;
            public StringField PictureFile;
            public Int32Field CavSets;
            public Int32Field CavSqInch;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DecimalField LifeTime;
            public DecimalField JobQty;
            public DecimalField FinQty;
            public DecimalField BalQty;
            public DecimalField RepQty;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Mold";
            }
        }
    }
}
