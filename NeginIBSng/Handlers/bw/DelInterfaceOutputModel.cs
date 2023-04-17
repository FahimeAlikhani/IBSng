namespace NeginIBSng.Handlers.bw
{
    public class DelInterfaceOutputModel : BaseModel
    {
        public int id { get; set; }
        public DelInterfaceResult result { get; set; }
        public string error { get; set; }
    }

    public class DelInterfaceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
