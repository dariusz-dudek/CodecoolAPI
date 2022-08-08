namespace CodecoolAPI.Data.Entries
{
    public class MaterialType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public IEnumerable<Material> Materials { get; set; } = new List<Material>();
    }
}
