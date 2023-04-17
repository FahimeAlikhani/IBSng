namespace NeginIBSng.Handlers.bw
{
    public class GetNodeInfoOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetNodeInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class GetNodeInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetNodeInfoData data { get; set; }
    }
    public class GetNodeInfoData
    {
        public int interface_id { get; set; }
        public string interface_name { get; set; }
        public string hostname { get; set; }
        public int node_id { get; set; }
        public int rate_kbits { get; set; }
        public int ceil_kbits { get; set; }
        public int priority { get; set; }
        public string description { get; set; }
        public float pkts { get; set; }
        public float bytes { get; set; }
        public float rate { get; set; }

    }
}
