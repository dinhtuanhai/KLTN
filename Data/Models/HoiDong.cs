﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class HoiDong
    {
        public HoiDong()
        {
            BoNhiem = new HashSet<BoNhiem>();
            XetDuyetVaDanhGia = new HashSet<XetDuyetVaDanhGia>();
        }

        public int Id { get; set; }
        public DateTime? NgayLap { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<BoNhiem> BoNhiem { get; set; }
        public virtual ICollection<XetDuyetVaDanhGia> XetDuyetVaDanhGia { get; set; }
    }
}
