namespace NeginIBSng.Handlers.admin
{
    public class GetAllAdminInfosOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetAllAdminInfosResult result { get; set; }
        public string error { get; set; }
    }

    public class GetAllAdminInfosResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<GetAllAdminInfosData> data { get; set; }
    }
    public class GetAllAdminInfosData
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
        public int last_activity { get; }
        public bool online_status { get; set; }
        public bool admin_has_otp { get; set; }

    }
}
