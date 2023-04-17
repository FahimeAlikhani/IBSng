namespace NeginIBSng.Handlers.bw
{
    public class AddLeafServiceOutputModel :BaseModel
    {
        public int id { get; set; }
        public AddLeafServiceResult result { get; set; }
        public string error { get; set; }
    }

    public class AddLeafServiceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
