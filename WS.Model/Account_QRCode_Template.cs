//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account_QRCode_Template
    {
        public System.Guid ATID { get; set; }
        public Nullable<System.Guid> AccountID { get; set; }
        public Nullable<System.Guid> TemplateID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string QRCodeBgImg { get; set; }
    
        public virtual OfficialAccounts OfficialAccounts { get; set; }
        public virtual QRCode_Templates QRCode_Templates { get; set; }
    }
}