﻿namespace WebApplication1.Data
{
    public class ChiTietDonHang
    {
        public Guid MaDh { get; set; }
        public Guid MaHh { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public DonHang DonHang { get; set; }
        public HangHoa HangHoa { get; set; }
    }
}
