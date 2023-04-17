namespace NeginIBSng.Handlers.bw
{
    public class GetRealHostInterfacesOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetRealHostInterfacesResult result { get; set; }
        public string error { get; set; }
    }

    public class GetRealHostInterfacesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<string> interfaces { get; set; }
    }
}
