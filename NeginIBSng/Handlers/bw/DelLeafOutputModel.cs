namespace NeginIBSng.Handlers.bw
{
    public class DelLeafOutputModel :BaseModel
    {
        public int id { get; set; }
        public DelLeafResult result { get; set; }
        public string error { get; set; }
    }

    public class DelLeafResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
