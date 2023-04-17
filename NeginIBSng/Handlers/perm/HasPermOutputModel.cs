namespace NeginIBSng.Handlers.perm
{
    public class HasPermOutputModel :BaseModel
    {
        public int id { get; set; }
        public HasPermResult result { get; set; }
        public string error { get; set; }
    }

    public class HasPermResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
