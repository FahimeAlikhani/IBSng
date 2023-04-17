namespace NeginIBSng.Handlers.isp
{
    public class GetISPInfoOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetISPInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class GetISPInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetISPInfoData Data { get; set; }
    }

    public class GetISPInfoData
    {
        public int isp_id { get; set; }
        public string isp_name { get; set; }
        public string parent_isp_name { get; set; }
        public bool isp_has_deposit_limit { get; set; }
        public float isp_deposit { get; set; }
        public int isp_mapped_user_id { get; set; }
        public string isp_mapped_user_repr { get; set; }
        public float isp_mapped_user_credit { get; set; }
        public int isp_online_users_count { get; set; }
        public bool isp_locked { get; set; }
        public string isp_auth_domain { get; set; }
        public string isp_web_domain { get; set; }
        public string isp_email { get; set; }
        public bool prevent_neg_deposit_login { get; set; }
        public string isp_comment { get; set; }
        public string isp_failed_username { get; set; }
        public string isp_failed_user_id { get; set; }
    }
}
