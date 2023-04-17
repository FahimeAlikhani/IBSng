namespace NeginIBSng.Handlers.isp
{
    public class GetISPUsersCreditOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetISPUsersCreditResult result { get; set; }
        public string error { get; set; }
    }

    public class GetISPUsersCreditResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
