namespace NeginIBSng.Handlers.bw
{
    public class AddNodeInputModell
    {
        public string hostname { get; set; }
        public string interface_name { get; set; }
        public int parent_id { get; set; }
        public int rate_kbits { get; set; }
        public int ceil_kbits { get; set; }
        public int priority { get; set; }

    }
}
    