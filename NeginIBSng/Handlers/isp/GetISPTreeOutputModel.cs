namespace NeginIBSng.Handlers.isp
{
    public class GetISPTreeOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetISPTreeResult result { get; set; }
        public string error { get; set; }
    }

    public class GetISPTreeResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
