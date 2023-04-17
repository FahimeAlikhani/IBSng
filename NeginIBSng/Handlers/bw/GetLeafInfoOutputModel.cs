namespace NeginIBSng.Handlers.bw
{
    public class GetLeafInfoOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetLeafInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class GetLeafInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetLeafInfoData data { get; set; }
        public List<GetLeafInfoservices> services { get; set; }
    }
    public class GetLeafInfoData
    {
        public int leaf_id { get; set; }
        public string leaf_name { get; set; }
        public int parent_id { get; set; }
        public int interface_id { get; set; }
        public string interface_name { get; set; }
        public string hostname { get; set; }
        public int total_rate_kbits { get; set; }
        public int total_ceil_kbits { get; set; }
        public int default_rate_kbits { get; set; }
        public int default_ceil_kbits { get; set; }
        public int default_priority { get; set; }
        public int total_priority { get; set; }

    }
    public class GetLeafInfoservices
    {
        public int leaf_service_id { get; set; }
        public string filter { get; set; }
        public string dst_ip { get; set; }
        public Protocol protocol { get; set; }
        public int rate_kbits { get; set; }
        public int ceil_kbits { get; set; }
        public int leaf_id { get; set; }
        public string leaf_name { set; get; }

        public int priority { get; set; }
    }
}
