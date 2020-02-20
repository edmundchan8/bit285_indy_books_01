﻿using System;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        //TODO: Add properties needed for searching
    }
}
