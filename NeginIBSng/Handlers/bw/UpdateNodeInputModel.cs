namespace NeginIBSng.Handlers.bw
{
    public class UpdateNodeInputModel
    {
        public int node_id { get; set; }
        public int rate_kbits { get; set; }
        public int ceil_kbits { get; set; }
        public int priority { get; set; }
    }
}
