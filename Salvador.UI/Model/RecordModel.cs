namespace Salvador.UI.Model
{
    public class RecordModel
    {
        public int Id { get; set; }
        public RecordModel()
        {
            Items = new List<RecordItemModel>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime TimeRecord { get; set; }
        public List<RecordItemModel> Items { get; set; }
    }
}
