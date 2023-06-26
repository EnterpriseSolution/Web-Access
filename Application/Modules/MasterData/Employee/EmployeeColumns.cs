#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  EmployeeColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.Employee")]
    [BasedOnRow(typeof(Entities.EmployeeRow))]
    public class EmployeeColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int32 Recnum { get; set; }
        [EditLink]
        public String EmployeeNo { get; set; }
       // public String Suspended { get; set; }
        public String ChineseName { get; set; }
        //public String EnglishName { get; set; }
        //public String PinyinName { get; set; }
        public String Department { get; set; }
        //public String Id { get; set; }
        public DateTime Birthday { get; set; }
        public String Gender { get; set; }
        //public String Marital { get; set; }
        //public String Nationality { get; set; }
       
        public String Homephone { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        //public String BusinessPhone { get; set; }
        //public String BusinessEmail { get; set; }
        public String Province { get; set; }
        public String City { get; set; }
        //public Stream Portrait { get; set; }
        //public String HireType { get; set; }
        //public DateTime HireDate { get; set; }
        //public DateTime HireValid { get; set; }
        //public DateTime HireSociety { get; set; }
        //public String HireSource { get; set; }
        //
        //public String ShiftNo { get; set; }
        //public String ContractType { get; set; }
        //public DateTime ContractStartDate { get; set; }
        //public DateTime ContractEndDate { get; set; }
        //public String ContractNumber { get; set; }
        //public String ContractLocation { get; set; }
        //public String Disablity { get; set; }
        //public String DisablityDescription { get; set; }
        //public String Height { get; set; }
        //public String Weight { get; set; }
        //public String EyeRight { get; set; }
        //public String EyeLeft { get; set; }
        //public String EyeColor { get; set; }
        //public String ShoeSize { get; set; }
        //public String ClothSize { get; set; }
        //public String BloodType { get; set; }
        //public DateTime QuitDate { get; set; }
        //public DateTime QuitNoticeDate { get; set; }
        //public DateTime QuitLeaveDate { get; set; }
        //public String QuitType { get; set; }
        //public String QuitReason { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        // public String BadgeNo { get; set; }
        //   public String Formula { get; set; }
        // public String WorkCentre { get; set; }
        //public String ProdDevt01 { get; set; }
        //public String ProdDevt02 { get; set; }
        //public String ProdDevt03 { get; set; }
        //public String ProdDevt04 { get; set; }
        //public String ProdDevt05 { get; set; }
        //public String ProdDevt06 { get; set; }
        //public String ProdDevt07 { get; set; }
        //public String ProdDevt08 { get; set; }
        //public String ProdDevt09 { get; set; }
        //public String ProdDevt10 { get; set; }
        //public String ProdDevt11 { get; set; }
        //public String ProdDevt12 { get; set; }
        //public String ProdDevt13 { get; set; }
        //public String ProdDevt14 { get; set; }
        //public String ProdDevt15 { get; set; }
        //public String ProdDevt16 { get; set; }
        //public String ProdDevt17 { get; set; }
        //public String ProdDevt18 { get; set; }
        //public String ProdDevt19 { get; set; }
        //public String ProdDevt20 { get; set; }
        //public String UserDefinedField1 { get; set; }
        //public String UserDefinedField2 { get; set; }
        //public String UserDefinedField3 { get; set; }
        //public String UserDefinedField4 { get; set; }
        //public String UserDefinedField5 { get; set; }
        //public String UserDefinedField6 { get; set; }
        //public String UserDefinedField7 { get; set; }
        //public String UserDefinedField8 { get; set; }
        //public String UserDefinedField9 { get; set; }
        //public String UserDefinedField10 { get; set; }
        //public String UserDefinedField11 { get; set; }
        //public String UserDefinedField12 { get; set; }
        //public String UserDefinedField13 { get; set; }
        //public String UserDefinedField14 { get; set; }
        //public String UserDefinedField15 { get; set; }
        //public String UserDefinedField16 { get; set; }
        //public String UserDefinedField17 { get; set; }
        //public String UserDefinedField18 { get; set; }
        //public String UserDefinedField19 { get; set; }
        //public String UserDefinedField20 { get; set; }
    }
}