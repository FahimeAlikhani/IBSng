namespace NeginIBSng.Handlers.bw
{
    public class GetInterfacesOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetInterfacesResult result { get; set; }
        public string error { get; set; }
    }

    public class GetInterfacesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetInterfacesData data { get; set; }
    }
    public class GetInterfacesData
    {
        public int interface_id { get; set; }
        public string interface_name { get; set; }
        public string hostname { get; set; }
        public Host_type host_type { get; set; }
        public string comment { get; set; }
    }
    public enum Host_type
    {
        Linux,
        Mikrotik,
    }
}
