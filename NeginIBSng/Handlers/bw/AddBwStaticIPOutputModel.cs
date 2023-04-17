namespace NeginIBSng.Handlers.bw
{
    public class AddBwStaticIPOutputModel : BaseModel
    {
        public int id { get; set; }
        public AddBwStaticIPResult result { get; set; }
        public string error { get; set; }
    }

    public class AddBwStaticIPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
