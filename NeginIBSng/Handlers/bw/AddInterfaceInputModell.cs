namespace NeginIBSng.Handlers.bw
{
    public class AddInterfaceInputModell
    {
        public string hostname { get; set; }
        public string interface_name { get; set; }
        public string comment { get; set; }
        public host_type host_type { get; set; }
     }
     public enum host_type {
        Linux,
        Mikrotik,
    }
}

