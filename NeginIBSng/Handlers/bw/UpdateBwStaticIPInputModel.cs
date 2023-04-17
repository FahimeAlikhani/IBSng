namespace NeginIBSng.Handlers.bw
{
    public class UpdateBwStaticIPInputModel
    {
        public int static_ip_id { get; set; }
        public string sip_addr { get; }
        public string tx_leaf_name { get; set; }
        public string rx_leaf_name { get; set; }
    }
}
