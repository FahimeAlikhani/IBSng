namespace NeginIBSng.Handlers.bw
{
    public class GetActiveLeavesOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetActiveLeavesResult result { get; set; }
        public string error { get; set; }
    }

    public class GetActiveLeavesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<Items> Item { get; set; }

    }
    public class Items
    {
        public Items[] Item { get; set; }
        public long Index { get; set; }
        public string Type { get; set; }
        public long Length { get; set; }
        public string Comment { get; set; }
    }

}

