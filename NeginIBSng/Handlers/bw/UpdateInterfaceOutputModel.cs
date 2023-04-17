namespace NeginIBSng.Handlers.bw
{
    public class UpdateInterfaceOutputModel :BaseModel
    {
        public int id { get; set; }
        public UpdateInterfaceResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateInterfaceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
