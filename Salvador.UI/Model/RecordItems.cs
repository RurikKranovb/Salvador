namespace Salvador.UI.Model
{
    public class RecordItems
    {
        public RecordItems()
        {
            Items = new List<RecordItem>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime TimeRecord { get; set; }
        public List<RecordItem> Items { get; set; }
    }
}
