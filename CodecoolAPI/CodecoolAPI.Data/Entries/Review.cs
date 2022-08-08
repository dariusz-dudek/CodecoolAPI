namespace CodecoolAPI.Data.Entries
{
    public class Review
    {
        public int Id { get; set; }
        public string RewievTExt { get; set; }
        public int RevievPoints { get; set; }
        public Material Material { get; set; }
        public int MaterialId { get; set; }
    }
}
