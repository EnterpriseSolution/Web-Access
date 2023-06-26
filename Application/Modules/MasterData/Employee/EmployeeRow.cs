#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  EmployeeRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBEMPL]")]
    [DisplayName("Employee"), InstanceName("Employee"), TwoLevelCached]   
    public sealed class EmployeeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Identity]
        public Int32? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Employee No"), Column("EMPLOYEE_NO"), Size(20), PrimaryKey, QuickSearch]
        public String EmployeeNo
        {
            get { return Fields.EmployeeNo[this]; }
            set { Fields.EmployeeNo[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1), NotNull]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Chinese Name"), Column("CHINESE_NAME"), Size(100)]
        public String ChineseName
        {
            get { return Fields.ChineseName[this]; }
            set { Fields.ChineseName[this] = value; }
        }

        [DisplayName("English Name"), Column("ENGLISH_NAME"), Size(250)]
        public String EnglishName
        {
            get { return Fields.EnglishName[this]; }
            set { Fields.EnglishName[this] = value; }
        }

        [DisplayName("Pinyin Name"), Column("PINYIN_NAME"), Size(100)]
        public String PinyinName
        {
            get { return Fields.PinyinName[this]; }
            set { Fields.PinyinName[this] = value; }
        }

        [DisplayName("Id"), Column("ID"), Size(50)]
        public String Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Birthday"), Column("BIRTHDAY")]
        public DateTime? Birthday
        {
            get { return Fields.Birthday[this]; }
            set { Fields.Birthday[this] = value; }
        }

        [DisplayName("Gender"), Column("GENDER"), Size(2)]
        public String Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("Marital"), Column("MARITAL"), Size(50)]
        public String Marital
        {
            get { return Fields.Marital[this]; }
            set { Fields.Marital[this] = value; }
        }

        [DisplayName("Nationality"), Column("NATIONALITY"), Size(10)]
        public String Nationality
        {
            get { return Fields.Nationality[this]; }
            set { Fields.Nationality[this] = value; }
        }

        [DisplayName("Province"), Column("PROVINCE"), Size(50)]
        public String Province
        {
            get { return Fields.Province[this]; }
            set { Fields.Province[this] = value; }
        }

        [DisplayName("City"), Column("CITY"), Size(20)]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("Homephone"), Column("HOMEPHONE"), Size(20)]
        public String Homephone
        {
            get { return Fields.Homephone[this]; }
            set { Fields.Homephone[this] = value; }
        }

        [DisplayName("Mobile"), Column("MOBILE"), Size(20)]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Email"), Column("EMAIL"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Business Phone"), Column("BUSINESS_PHONE"), Size(20)]
        public String BusinessPhone
        {
            get { return Fields.BusinessPhone[this]; }
            set { Fields.BusinessPhone[this] = value; }
        }

        [DisplayName("Business Email"), Column("BUSINESS_EMAIL"), Size(20)]
        public String BusinessEmail
        {
            get { return Fields.BusinessEmail[this]; }
            set { Fields.BusinessEmail[this] = value; }
        }

        [DisplayName("Portrait"), Column("PORTRAIT"), Size(2147483647)]
        public Stream Portrait
        {
            get { return Fields.Portrait[this]; }
            set { Fields.Portrait[this] = value; }
        }

        [DisplayName("Hire Type"), Column("HIRE_TYPE"), Size(10)]
        public String HireType
        {
            get { return Fields.HireType[this]; }
            set { Fields.HireType[this] = value; }
        }

        [DisplayName("Hire Date"), Column("HIRE_DATE")]
        public DateTime? HireDate
        {
            get { return Fields.HireDate[this]; }
            set { Fields.HireDate[this] = value; }
        }

        [DisplayName("Hire Valid"), Column("HIRE_VALID")]
        public DateTime? HireValid
        {
            get { return Fields.HireValid[this]; }
            set { Fields.HireValid[this] = value; }
        }

        [DisplayName("Hire Society"), Column("HIRE_SOCIETY")]
        public DateTime? HireSociety
        {
            get { return Fields.HireSociety[this]; }
            set { Fields.HireSociety[this] = value; }
        }

        [DisplayName("Hire Source"), Column("HIRE_SOURCE"), Size(50)]
        public String HireSource
        {
            get { return Fields.HireSource[this]; }
            set { Fields.HireSource[this] = value; }
        }

        [DisplayName("Department"), Column("DEPARTMENT"), Size(50)]
        public String Department
        {
            get { return Fields.Department[this]; }
            set { Fields.Department[this] = value; }
        }

        [DisplayName("Shift No"), Column("SHIFT_NO"), Size(10)]
        public String ShiftNo
        {
            get { return Fields.ShiftNo[this]; }
            set { Fields.ShiftNo[this] = value; }
        }

        [DisplayName("Contract Type"), Column("CONTRACT_TYPE"), Size(10)]
        public String ContractType
        {
            get { return Fields.ContractType[this]; }
            set { Fields.ContractType[this] = value; }
        }

        [DisplayName("Contract Start Date"), Column("CONTRACT_START_DATE")]
        public DateTime? ContractStartDate
        {
            get { return Fields.ContractStartDate[this]; }
            set { Fields.ContractStartDate[this] = value; }
        }

        [DisplayName("Contract End Date"), Column("CONTRACT_END_DATE")]
        public DateTime? ContractEndDate
        {
            get { return Fields.ContractEndDate[this]; }
            set { Fields.ContractEndDate[this] = value; }
        }

        [DisplayName("Contract Number"), Column("CONTRACT_NUMBER"), Size(20)]
        public String ContractNumber
        {
            get { return Fields.ContractNumber[this]; }
            set { Fields.ContractNumber[this] = value; }
        }

        [DisplayName("Contract Location"), Column("CONTRACT_LOCATION"), Size(100)]
        public String ContractLocation
        {
            get { return Fields.ContractLocation[this]; }
            set { Fields.ContractLocation[this] = value; }
        }

        [DisplayName("Disablity"), Column("DISABLITY"), Size(1)]
        public String Disablity
        {
            get { return Fields.Disablity[this]; }
            set { Fields.Disablity[this] = value; }
        }

        [DisplayName("Disablity Description"), Column("DISABLITY_DESCRIPTION"), Size(50)]
        public String DisablityDescription
        {
            get { return Fields.DisablityDescription[this]; }
            set { Fields.DisablityDescription[this] = value; }
        }

        [DisplayName("Height"), Column("HEIGHT"), Size(20)]
        public String Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("Weight"), Column("WEIGHT"), Size(20)]
        public String Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("Eye Right"), Column("EYE_RIGHT"), Size(10)]
        public String EyeRight
        {
            get { return Fields.EyeRight[this]; }
            set { Fields.EyeRight[this] = value; }
        }

        [DisplayName("Eye Left"), Column("EYE_LEFT"), Size(10)]
        public String EyeLeft
        {
            get { return Fields.EyeLeft[this]; }
            set { Fields.EyeLeft[this] = value; }
        }

        [DisplayName("Eye Color"), Column("EYE_COLOR"), Size(20)]
        public String EyeColor
        {
            get { return Fields.EyeColor[this]; }
            set { Fields.EyeColor[this] = value; }
        }

        [DisplayName("Shoe Size"), Column("SHOE_SIZE"), Size(40)]
        public String ShoeSize
        {
            get { return Fields.ShoeSize[this]; }
            set { Fields.ShoeSize[this] = value; }
        }

        [DisplayName("Cloth Size"), Column("CLOTH_SIZE"), Size(40)]
        public String ClothSize
        {
            get { return Fields.ClothSize[this]; }
            set { Fields.ClothSize[this] = value; }
        }

        [DisplayName("Blood Type"), Column("BLOOD_TYPE"), Size(2)]
        public String BloodType
        {
            get { return Fields.BloodType[this]; }
            set { Fields.BloodType[this] = value; }
        }

        [DisplayName("Quit Date"), Column("QUIT_DATE")]
        public DateTime? QuitDate
        {
            get { return Fields.QuitDate[this]; }
            set { Fields.QuitDate[this] = value; }
        }

        [DisplayName("Quit Notice Date"), Column("QUIT_NOTICE_DATE")]
        public DateTime? QuitNoticeDate
        {
            get { return Fields.QuitNoticeDate[this]; }
            set { Fields.QuitNoticeDate[this] = value; }
        }

        [DisplayName("Quit Leave Date"), Column("QUIT_LEAVE_DATE")]
        public DateTime? QuitLeaveDate
        {
            get { return Fields.QuitLeaveDate[this]; }
            set { Fields.QuitLeaveDate[this] = value; }
        }

        [DisplayName("Quit Type"), Column("QUIT_TYPE"), Size(10)]
        public String QuitType
        {
            get { return Fields.QuitType[this]; }
            set { Fields.QuitType[this] = value; }
        }

        [DisplayName("Quit Reason"), Column("QUIT_REASON"), Size(100)]
        public String QuitReason
        {
            get { return Fields.QuitReason[this]; }
            set { Fields.QuitReason[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(20)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(20)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Badge No"), Column("BADGE_NO"), Size(20), NotNull]
        public String BadgeNo
        {
            get { return Fields.BadgeNo[this]; }
            set { Fields.BadgeNo[this] = value; }
        }

        [DisplayName("Formula"), Column("FORMULA"), Size(50)]
        public String Formula
        {
            get { return Fields.Formula[this]; }
            set { Fields.Formula[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(50)]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        [DisplayName("Prod Devt01"), Column("PROD_DEVT01"), Size(200)]
        public String ProdDevt01
        {
            get { return Fields.ProdDevt01[this]; }
            set { Fields.ProdDevt01[this] = value; }
        }

        [DisplayName("Prod Devt02"), Column("PROD_DEVT02"), Size(200)]
        public String ProdDevt02
        {
            get { return Fields.ProdDevt02[this]; }
            set { Fields.ProdDevt02[this] = value; }
        }

        [DisplayName("Prod Devt03"), Column("PROD_DEVT03"), Size(200)]
        public String ProdDevt03
        {
            get { return Fields.ProdDevt03[this]; }
            set { Fields.ProdDevt03[this] = value; }
        }

        [DisplayName("Prod Devt04"), Column("PROD_DEVT04"), Size(200)]
        public String ProdDevt04
        {
            get { return Fields.ProdDevt04[this]; }
            set { Fields.ProdDevt04[this] = value; }
        }

        [DisplayName("Prod Devt05"), Column("PROD_DEVT05"), Size(200)]
        public String ProdDevt05
        {
            get { return Fields.ProdDevt05[this]; }
            set { Fields.ProdDevt05[this] = value; }
        }

        [DisplayName("Prod Devt06"), Column("PROD_DEVT06"), Size(200)]
        public String ProdDevt06
        {
            get { return Fields.ProdDevt06[this]; }
            set { Fields.ProdDevt06[this] = value; }
        }

        [DisplayName("Prod Devt07"), Column("PROD_DEVT07"), Size(200)]
        public String ProdDevt07
        {
            get { return Fields.ProdDevt07[this]; }
            set { Fields.ProdDevt07[this] = value; }
        }

        [DisplayName("Prod Devt08"), Column("PROD_DEVT08"), Size(200)]
        public String ProdDevt08
        {
            get { return Fields.ProdDevt08[this]; }
            set { Fields.ProdDevt08[this] = value; }
        }

        [DisplayName("Prod Devt09"), Column("PROD_DEVT09"), Size(200)]
        public String ProdDevt09
        {
            get { return Fields.ProdDevt09[this]; }
            set { Fields.ProdDevt09[this] = value; }
        }

        [DisplayName("Prod Devt10"), Column("PROD_DEVT10"), Size(200)]
        public String ProdDevt10
        {
            get { return Fields.ProdDevt10[this]; }
            set { Fields.ProdDevt10[this] = value; }
        }

        [DisplayName("Prod Devt11"), Column("PROD_DEVT11"), Size(200)]
        public String ProdDevt11
        {
            get { return Fields.ProdDevt11[this]; }
            set { Fields.ProdDevt11[this] = value; }
        }

        [DisplayName("Prod Devt12"), Column("PROD_DEVT12"), Size(200)]
        public String ProdDevt12
        {
            get { return Fields.ProdDevt12[this]; }
            set { Fields.ProdDevt12[this] = value; }
        }

        [DisplayName("Prod Devt13"), Column("PROD_DEVT13"), Size(200)]
        public String ProdDevt13
        {
            get { return Fields.ProdDevt13[this]; }
            set { Fields.ProdDevt13[this] = value; }
        }

        [DisplayName("Prod Devt14"), Column("PROD_DEVT14"), Size(200)]
        public String ProdDevt14
        {
            get { return Fields.ProdDevt14[this]; }
            set { Fields.ProdDevt14[this] = value; }
        }

        [DisplayName("Prod Devt15"), Column("PROD_DEVT15"), Size(200)]
        public String ProdDevt15
        {
            get { return Fields.ProdDevt15[this]; }
            set { Fields.ProdDevt15[this] = value; }
        }

        [DisplayName("Prod Devt16"), Column("PROD_DEVT16"), Size(200)]
        public String ProdDevt16
        {
            get { return Fields.ProdDevt16[this]; }
            set { Fields.ProdDevt16[this] = value; }
        }

        [DisplayName("Prod Devt17"), Column("PROD_DEVT17"), Size(200)]
        public String ProdDevt17
        {
            get { return Fields.ProdDevt17[this]; }
            set { Fields.ProdDevt17[this] = value; }
        }

        [DisplayName("Prod Devt18"), Column("PROD_DEVT18"), Size(200)]
        public String ProdDevt18
        {
            get { return Fields.ProdDevt18[this]; }
            set { Fields.ProdDevt18[this] = value; }
        }

        [DisplayName("Prod Devt19"), Column("PROD_DEVT19"), Size(200)]
        public String ProdDevt19
        {
            get { return Fields.ProdDevt19[this]; }
            set { Fields.ProdDevt19[this] = value; }
        }

        [DisplayName("Prod Devt20"), Column("PROD_DEVT20"), Size(200)]
        public String ProdDevt20
        {
            get { return Fields.ProdDevt20[this]; }
            set { Fields.ProdDevt20[this] = value; }
        }

        [DisplayName("User Defined Field 1"), Column("USER_DEFINED_FIELD_1"), Size(100)]
        public String UserDefinedField1
        {
            get { return Fields.UserDefinedField1[this]; }
            set { Fields.UserDefinedField1[this] = value; }
        }

        [DisplayName("User Defined Field 2"), Column("USER_DEFINED_FIELD_2"), Size(100)]
        public String UserDefinedField2
        {
            get { return Fields.UserDefinedField2[this]; }
            set { Fields.UserDefinedField2[this] = value; }
        }

        [DisplayName("User Defined Field 3"), Column("USER_DEFINED_FIELD_3"), Size(100)]
        public String UserDefinedField3
        {
            get { return Fields.UserDefinedField3[this]; }
            set { Fields.UserDefinedField3[this] = value; }
        }

        [DisplayName("User Defined Field 4"), Column("USER_DEFINED_FIELD_4"), Size(100)]
        public String UserDefinedField4
        {
            get { return Fields.UserDefinedField4[this]; }
            set { Fields.UserDefinedField4[this] = value; }
        }

        [DisplayName("User Defined Field 5"), Column("USER_DEFINED_FIELD_5"), Size(100)]
        public String UserDefinedField5
        {
            get { return Fields.UserDefinedField5[this]; }
            set { Fields.UserDefinedField5[this] = value; }
        }

        [DisplayName("User Defined Field 6"), Column("USER_DEFINED_FIELD_6"), Size(100)]
        public String UserDefinedField6
        {
            get { return Fields.UserDefinedField6[this]; }
            set { Fields.UserDefinedField6[this] = value; }
        }

        [DisplayName("User Defined Field 7"), Column("USER_DEFINED_FIELD_7"), Size(100)]
        public String UserDefinedField7
        {
            get { return Fields.UserDefinedField7[this]; }
            set { Fields.UserDefinedField7[this] = value; }
        }

        [DisplayName("User Defined Field 8"), Column("USER_DEFINED_FIELD_8"), Size(100)]
        public String UserDefinedField8
        {
            get { return Fields.UserDefinedField8[this]; }
            set { Fields.UserDefinedField8[this] = value; }
        }

        [DisplayName("User Defined Field 9"), Column("USER_DEFINED_FIELD_9"), Size(100)]
        public String UserDefinedField9
        {
            get { return Fields.UserDefinedField9[this]; }
            set { Fields.UserDefinedField9[this] = value; }
        }

        [DisplayName("User Defined Field 10"), Column("USER_DEFINED_FIELD_10"), Size(100)]
        public String UserDefinedField10
        {
            get { return Fields.UserDefinedField10[this]; }
            set { Fields.UserDefinedField10[this] = value; }
        }

        [DisplayName("User Defined Field 11"), Column("USER_DEFINED_FIELD_11"), Size(100)]
        public String UserDefinedField11
        {
            get { return Fields.UserDefinedField11[this]; }
            set { Fields.UserDefinedField11[this] = value; }
        }

        [DisplayName("User Defined Field 12"), Column("USER_DEFINED_FIELD_12"), Size(100)]
        public String UserDefinedField12
        {
            get { return Fields.UserDefinedField12[this]; }
            set { Fields.UserDefinedField12[this] = value; }
        }

        [DisplayName("User Defined Field 13"), Column("USER_DEFINED_FIELD_13"), Size(100)]
        public String UserDefinedField13
        {
            get { return Fields.UserDefinedField13[this]; }
            set { Fields.UserDefinedField13[this] = value; }
        }

        [DisplayName("User Defined Field 14"), Column("USER_DEFINED_FIELD_14"), Size(100)]
        public String UserDefinedField14
        {
            get { return Fields.UserDefinedField14[this]; }
            set { Fields.UserDefinedField14[this] = value; }
        }

        [DisplayName("User Defined Field 15"), Column("USER_DEFINED_FIELD_15"), Size(100)]
        public String UserDefinedField15
        {
            get { return Fields.UserDefinedField15[this]; }
            set { Fields.UserDefinedField15[this] = value; }
        }

        [DisplayName("User Defined Field 16"), Column("USER_DEFINED_FIELD_16"), Size(100)]
        public String UserDefinedField16
        {
            get { return Fields.UserDefinedField16[this]; }
            set { Fields.UserDefinedField16[this] = value; }
        }

        [DisplayName("User Defined Field 17"), Column("USER_DEFINED_FIELD_17"), Size(100)]
        public String UserDefinedField17
        {
            get { return Fields.UserDefinedField17[this]; }
            set { Fields.UserDefinedField17[this] = value; }
        }

        [DisplayName("User Defined Field 18"), Column("USER_DEFINED_FIELD_18"), Size(100)]
        public String UserDefinedField18
        {
            get { return Fields.UserDefinedField18[this]; }
            set { Fields.UserDefinedField18[this] = value; }
        }

        [DisplayName("User Defined Field 19"), Column("USER_DEFINED_FIELD_19"), Size(100)]
        public String UserDefinedField19
        {
            get { return Fields.UserDefinedField19[this]; }
            set { Fields.UserDefinedField19[this] = value; }
        }

        [DisplayName("User Defined Field 20"), Column("USER_DEFINED_FIELD_20"), Size(100)]
        public String UserDefinedField20
        {
            get { return Fields.UserDefinedField20[this]; }
            set { Fields.UserDefinedField20[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EmployeeNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EmployeeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Recnum;
            public StringField EmployeeNo;
            public StringField Suspended;
            public StringField ChineseName;
            public StringField EnglishName;
            public StringField PinyinName;
            public StringField Id;
            public DateTimeField Birthday;
            public StringField Gender;
            public StringField Marital;
            public StringField Nationality;
            public StringField Province;
            public StringField City;
            public StringField Homephone;
            public StringField Mobile;
            public StringField Email;
            public StringField BusinessPhone;
            public StringField BusinessEmail;
            public StreamField Portrait;
            public StringField HireType;
            public DateTimeField HireDate;
            public DateTimeField HireValid;
            public DateTimeField HireSociety;
            public StringField HireSource;
            public StringField Department;
            public StringField ShiftNo;
            public StringField ContractType;
            public DateTimeField ContractStartDate;
            public DateTimeField ContractEndDate;
            public StringField ContractNumber;
            public StringField ContractLocation;
            public StringField Disablity;
            public StringField DisablityDescription;
            public StringField Height;
            public StringField Weight;
            public StringField EyeRight;
            public StringField EyeLeft;
            public StringField EyeColor;
            public StringField ShoeSize;
            public StringField ClothSize;
            public StringField BloodType;
            public DateTimeField QuitDate;
            public DateTimeField QuitNoticeDate;
            public DateTimeField QuitLeaveDate;
            public StringField QuitType;
            public StringField QuitReason;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField BadgeNo;
            public StringField Formula;
            public StringField WorkCentre;
            public StringField ProdDevt01;
            public StringField ProdDevt02;
            public StringField ProdDevt03;
            public StringField ProdDevt04;
            public StringField ProdDevt05;
            public StringField ProdDevt06;
            public StringField ProdDevt07;
            public StringField ProdDevt08;
            public StringField ProdDevt09;
            public StringField ProdDevt10;
            public StringField ProdDevt11;
            public StringField ProdDevt12;
            public StringField ProdDevt13;
            public StringField ProdDevt14;
            public StringField ProdDevt15;
            public StringField ProdDevt16;
            public StringField ProdDevt17;
            public StringField ProdDevt18;
            public StringField ProdDevt19;
            public StringField ProdDevt20;
            public StringField UserDefinedField1;
            public StringField UserDefinedField2;
            public StringField UserDefinedField3;
            public StringField UserDefinedField4;
            public StringField UserDefinedField5;
            public StringField UserDefinedField6;
            public StringField UserDefinedField7;
            public StringField UserDefinedField8;
            public StringField UserDefinedField9;
            public StringField UserDefinedField10;
            public StringField UserDefinedField11;
            public StringField UserDefinedField12;
            public StringField UserDefinedField13;
            public StringField UserDefinedField14;
            public StringField UserDefinedField15;
            public StringField UserDefinedField16;
            public StringField UserDefinedField17;
            public StringField UserDefinedField18;
            public StringField UserDefinedField19;
            public StringField UserDefinedField20;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Employee";
            }
        }
    }
}
