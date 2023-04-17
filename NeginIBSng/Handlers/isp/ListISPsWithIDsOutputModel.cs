namespace NeginIBSng.Handlers.isp
{
    public class ListISPsWithIDsOutputModel : BaseModel
    {
        public int id { get; set; }
        public ListISPsWithIDsResult result { get; set; }
        public string error { get; set; }
    }

    public class ListISPsWithIDsResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<Items> item { get; set; }
    }
}
