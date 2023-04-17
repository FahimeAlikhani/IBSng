namespace NeginIBSng.Handlers.bw
{
    public class UpdateInterfaceInputModel
    {
        public int interface_id { get; set; }
        public string hostname { get; set; }
        public string interface_name { get; set; }
        public string comment { get; set; }
        public host_type host_type { get; set; }
    }
}
