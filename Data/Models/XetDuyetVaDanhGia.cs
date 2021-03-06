﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class XetDuyetVaDanhGia
    {
        public XetDuyetVaDanhGia()
        {
            CtxetDuyetVaDanhGia = new HashSet<CtxetDuyetVaDanhGia>();
        }

        public int Id { get; set; }
        public int? IddeTai { get; set; }
        public int? IdhoiDong { get; set; }
        public int? IdmoDot { get; set; }
        public int? Status { get; set; }

        public virtual DeTaiNghienCuu IddeTaiNavigation { get; set; }
        public virtual HoiDong IdhoiDongNavigation { get; set; }
        public virtual MoDot IdmoDotNavigation { get; set; }
        public virtual ICollection<CtxetDuyetVaDanhGia> CtxetDuyetVaDanhGia { get; set; }
    }
}
