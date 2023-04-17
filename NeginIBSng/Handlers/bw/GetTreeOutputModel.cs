namespace NeginIBSng.Handlers.bw
{
    public class GetTreeOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetTreeResult result { get; set; }
        public string error { get; set; }
    }

    public class GetTreeResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<Items> Item { get; set; }

    }
}
