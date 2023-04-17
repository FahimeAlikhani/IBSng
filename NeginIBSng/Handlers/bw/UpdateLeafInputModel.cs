namespace NeginIBSng.Handlers.bw
{
    public class UpdateLeafInputModel
    {
        public int leaf_id { get; set; }
        public string leaf_name { get; set; }
        public int default_rate_kbits { get; set; }
        public int default_ceil_kbits { get; set; }
        public int total_rate_kbits { get; set; }
        public int total_ceil_kbits { get; set; }
        public int default_priority { get; set; }
        public int total_priority { get; set; }
    }
}
