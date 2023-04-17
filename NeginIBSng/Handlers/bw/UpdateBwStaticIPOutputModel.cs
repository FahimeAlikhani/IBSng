namespace NeginIBSng.Handlers.bw
{
    public class UpdateBwStaticIPOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateBwStaticIPResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateBwStaticIPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
