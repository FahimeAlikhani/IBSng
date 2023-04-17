namespace NeginIBSng.Handlers.isp
{
    public class DeleteISPOutputModel : BaseModel
    {
        public int id { get; set; }
        public DeleteISPResult result { get; set; }
        public string error { get; set; }
    }

    public class DeleteISPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
