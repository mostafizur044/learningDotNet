﻿namespace Services.DTO
{
    public class GetProducts
    {
        public int Page { get; set; } = 0;
        public int PageNo { get; set; } = 10;
        public string Name { get; set; }
        public string SKU { get; set; }
    }
}
