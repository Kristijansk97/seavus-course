﻿using System.ComponentModel;

namespace ViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }
    }
}
