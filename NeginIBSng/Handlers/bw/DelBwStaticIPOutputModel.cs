namespace NeginIBSng.Handlers.bw
{
    public class DelBwStaticIPOutputModel :BaseModel
    {
        public int id { get; set; }
        public DelBwStaticIPIPResult result { get; set; }
        public string error { get; set; }
    }

    public class DelBwStaticIPIPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
