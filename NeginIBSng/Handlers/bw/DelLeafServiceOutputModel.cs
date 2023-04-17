namespace NeginIBSng.Handlers.bw
{
    public class DelLeafServiceOutputModel:BaseModel
    {
        public int id { get; set; }
        public DelLeafServiceResult result { get; set; }
        public string error { get; set; }
    }

    public class DelLeafServiceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
