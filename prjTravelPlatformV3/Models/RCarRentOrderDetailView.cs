﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class RCarRentOrderDetailView
{
    public int 訂單明細編號 { get; set; }

    public string 訂單編號 { get; set; }

    public string 車牌號碼 { get; set; }

    public string 車輛型號 { get; set; }

    public string 駕駛姓名 { get; set; }

    public string 駕駛身分證 { get; set; }

    public DateTime? 起租時間 { get; set; }

    public string 取車據點 { get; set; }

    public DateTime? 還車時間 { get; set; }

    public string 還車據點 { get; set; }

    public decimal? 租車費用 { get; set; }
}