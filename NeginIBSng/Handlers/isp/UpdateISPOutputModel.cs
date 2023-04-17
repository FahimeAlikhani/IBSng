namespace NeginIBSng.Handlers.isp
{
    public class HasPermOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateISPResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateISPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
