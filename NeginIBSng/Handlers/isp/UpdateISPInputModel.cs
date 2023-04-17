namespace NeginIBSng.Handlers.isp
{
    public class HasPermInputModel
    {
        public int isp_id { get; set; }
        public string isp_name { get; set; }
        public string parent_isp_name { get; set; }
        public bool isp_has_deposit_limit { get; set; }
        public int isp_mapped_user_id { get; set; }
        public string isp_auth_domain { get; set; }
        public string isp_web_domain { get; set; }
        public string isp_email { get; set; }
        public bool prevent_neg_deposit_login { get; set; }
        public string isp_comment { get; set; }
        public int isp_failed_user_id { get; set; }
        public bool isp_locked { get; set; }
    }
}
