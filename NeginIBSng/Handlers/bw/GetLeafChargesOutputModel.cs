namespace NeginIBSng.Handlers.bw
{
    public class GetLeafChargesOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetLeafChargesResult result { get; set; }
        public string error { get; set; }
    }

    public class GetLeafChargesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<string> results { get; set; }
    }
}
