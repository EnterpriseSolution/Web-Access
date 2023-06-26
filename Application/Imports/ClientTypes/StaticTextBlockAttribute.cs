#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StaticTextBlockAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Matrix
{
    public partial class StaticTextBlockAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.StaticTextBlock";

        public StaticTextBlockAttribute()
            : base(Key)
        {
        }

        public Boolean HideLabel
        {
            get { return GetOption<Boolean>("hideLabel"); }
            set { SetOption("hideLabel", value); }
        }

        public Boolean IsHtml
        {
            get { return GetOption<Boolean>("isHtml"); }
            set { SetOption("isHtml", value); }
        }

        public Boolean IsLocalText
        {
            get { return GetOption<Boolean>("isLocalText"); }
            set { SetOption("isLocalText", value); }
        }

        public String Text
        {
            get { return GetOption<String>("text"); }
            set { SetOption("text", value); }
        }
    }
}

