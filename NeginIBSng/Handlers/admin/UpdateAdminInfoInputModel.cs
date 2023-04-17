namespace NeginIBSng.Handlers.admin
{
    public class UpdateAdminInfoInputModel
    {
        public int AdminId { get; set; }
        public string admin_username { get; set; }
        public string admin_isp_name { get; set; }
        public bool admin_locked { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public bool admin_has_otp { get; set; }
        public int admin_request_limit { get; set; }
    }
}
