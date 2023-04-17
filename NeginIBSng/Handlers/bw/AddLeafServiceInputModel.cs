namespace NeginIBSng.Handlers.bw
{
    public class AddLeafServiceInputModel
    {
        public string leaf_name { get; set; }
        public string dst_ip { get; set; }
        public Protocol protocol { get; set; }
        public string filter { get; set; }
        public int rate_kbits { get; set; }
        public int ceil_kbits { get; set; }
        public int priority { get; set; }
    }
    public enum Protocol
    {
        tcp,
        udp,
        icmp,
        ip,
    }
}
