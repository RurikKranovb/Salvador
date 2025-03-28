﻿using Salvador.Domain.Entities;
using Salvador.UI.Model;
using Salvador.UI.ViewModel;

namespace Salvador.UI.Infrastructure.Mapping
{
    public static class RecordMapping
    {
        public static RecordViewModel ToView(this Record items) => new RecordViewModel()
        {
            Id = items.Id,
            StartDate = items.StartDate,
            Name = items.Name,
            Price = items.Price,
            EndDate = items.EndDate,
            Items = items.Items.Select(item => new RecordItemViewModel()
            {
                WorkTime = item.WorkTime,
                Name = item.Name,
                Price = item.Price,
                Id = item.Id
            }).ToList()
        };
    }
}
