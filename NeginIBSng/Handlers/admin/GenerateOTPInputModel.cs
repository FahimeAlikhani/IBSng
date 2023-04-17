namespace NeginIBSng.Handlers.admin
{
    public class GenerateOTPInputModel
    {
        public int pass_len { get; set; }
        public int pass_count { get; set; }
        public string admin_username { get; set; }
    }
}
