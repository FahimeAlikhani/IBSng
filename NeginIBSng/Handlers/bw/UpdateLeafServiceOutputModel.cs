namespace NeginIBSng.Handlers.bw
{
    public class UpdateLeafServiceOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateLeafServiceResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateLeafServiceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
