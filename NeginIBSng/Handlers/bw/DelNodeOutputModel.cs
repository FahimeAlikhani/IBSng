namespace NeginIBSng.Handlers.bw
{
    public class DelNodeOutputModel :BaseModel
    {
        public int id { get; set; }
        public DelNodeResult result { get; set; }
        public string error { get; set; }
    }

    public class DelNodeResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
