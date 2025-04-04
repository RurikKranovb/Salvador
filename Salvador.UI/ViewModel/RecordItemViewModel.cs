﻿using Salvador.Domain.Entities.Base;
using Salvador.Domain.Entities.Base.Interface;

namespace Salvador.UI.ViewModel
{
    public class RecordItemViewModel : IDefaultEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public TimeSpan WorkTime { get; set; } 
    }
}
