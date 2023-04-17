namespace NeginIBSng.Handlers.bw
{
    public class UpdateLeafOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateLeafResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateLeafResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
