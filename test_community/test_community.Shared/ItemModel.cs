namespace test_community
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Id}-{Name}";
    }
}
