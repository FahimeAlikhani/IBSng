namespace NeginIBSng.Handlers
{
    public class GetAdminInfoOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetAdminInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class GetAdminInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetAdminInfoData data { get; set; }
    }
    public class GetAdminInfoData
    {
        public int admin_id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public string isp_name { get; set; }
        public string creator_admin_username { get; set; }
        public bool locked { get; set; }
        public string last_request_ip { get; set; }
        public int last_activity { get; set; }
        public bool online_status { get; set; }
        public bool admin_has_otp { get; set; }
    }
}
