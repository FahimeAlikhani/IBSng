namespace NeginIBSng.Handlers.bw
{
    public class GetBwStaticIPInfoOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetBwStaticIPInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class GetBwStaticIPInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetBwStaticIPInfoData data { get; set; }
    }
    public class GetBwStaticIPInfoData
    {
        public int static_ip_id { get; set; }
        public string ip { get; set; }
        public int tx_leaf_id { get; set; }
        public string tx_leaf_name { get; set; }
        public int rx_leaf_id { get; set; }
        public string rx_leaf_name { get; set;}
    }
}
