﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class CusCouponView
{
    public int 客戶編號 { get; set; }

    public string 客戶名稱 { get; set; }

    public string 折扣碼 { get; set; }

    public string 優惠卷名稱 { get; set; }

    public DateTime? 啟用日期 { get; set; }

    public DateTime? 截止日期 { get; set; }

    public bool 使用狀態 { get; set; }
}