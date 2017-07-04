﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBContainer : DbContext
    {
        public DBContainer()
            : base("name=DBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SysSample> SysSample { get; set; }
        public virtual DbSet<SysModule> SysModule { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysException> SysException { get; set; }
        public virtual DbSet<SysModuleOperate> SysModuleOperate { get; set; }
        public virtual DbSet<SysRight> SysRight { get; set; }
        public virtual DbSet<SysRightOperate> SysRightOperate { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
    
        public virtual ObjectResult<P_Sys_GetRightOperate2_Result> P_Sys_GetRightOperate2(string userId, string url)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_Sys_GetRightOperate2_Result>("P_Sys_GetRightOperate2", userIdParameter, urlParameter);
        }
    }
}