namespace NeginIBSng.Handlers.bw
{
    public class UpdateNodeOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateNodeResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateNodeResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
