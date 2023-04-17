namespace NeginIBSng.Handlers.admin
{
    public class SearchOTPsOutputModel : BaseModel
    {
        public int id { get; set; }
        public AddNewAdminResult result { get; set; }
        public string error { get; set; }
    }

    public class AddNewAdminResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public AddNewAdminData data { get; set; }
    }
    public class AddNewAdminData
    {
        public int total_rows { get; set; }
        public List<AddNewAdminReport>  report { get; set; }
    }
    public class AddNewAdminReport
    {
        public int otp_id { get; set; }
        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public string password { get; set; }
        public string expired { get; set; }
        public string used_date { get; set; }
        public string used_date_formatted { get; set; }
        public string creation_date { get; set; }
        public string creation_date_formatted { get; set; }
        public string remote_addr { get; set; }

    }
}