using Salvador.Domain.Entities;
using Salvador.UI.Model;

namespace Salvador.UI.Initialize
{
    public class TestData
    {

        public static List<RecordItem> Items = new()
        {
            new()
            {
                Name = "Стрижка",
                Price = 1111,
                WorkTime = TimeSpan.FromSeconds(3600)
            },
            new()
            {
                Name = "Укладка",
                Price = 2222,
                WorkTime = TimeSpan.FromSeconds(3600)
            },
            new()
            {
                Name = "Мелирование",
                Price = 3333,
                WorkTime = TimeSpan.FromSeconds(3600)
            },
            new()
            {
                Name = "Окрашивание",
                Price = 4444,
                WorkTime = TimeSpan.FromSeconds(3600)
            },
        };

        public static List<Record> RecordItemsList { get; } = new()
        {
            new()
            {
                Name = "Элеанора",
                Phone = "89511745698",
                StartDate = new DateTime(2025,03,05,19,20,00),
                EndDate = new DateTime(2025,03,05,19,20,00),
                Items = new List<RecordItem>()
                {
                    new()
                    {
                        Name = "Стрижка",
                        Price = 1111,
                        WorkTime = TimeSpan.FromSeconds(3600)
                    },
                    new()
                    {
                        Name = "Укладка",
                        Price = 2222,
                        WorkTime = TimeSpan.FromSeconds(3600)
                    },
                }
            },
            new()
            {
                Name = "Василий",
                Phone = "89536852297",
                StartDate = new DateTime(2025,03,05,15,36,00),
                EndDate = new DateTime(2025,03,05,19,20,00),
                Items = new List<RecordItem>()
                {
                    new()
                    {
                        Name = "Стрижка",
                        Price = 1111,
                        WorkTime = TimeSpan.FromSeconds(3600)
                    },
                    new()
                    {
                        Name = "Окрашивание",
                        Price = 4444,
                        WorkTime = TimeSpan.FromSeconds(3600)
                    },
                }
            }
        };

    }
}
