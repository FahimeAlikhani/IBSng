namespace NeginIBSng.Handlers.admin
{
    public class GetAllAdminUsernamesOutputModel : BaseModel
    {
        public int id { get; set; }
        public GetAllAdminUsernamesResult result { get; set; }
        public string error { get; set; }
    }

    public class GetAllAdminUsernamesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<GetAllAdminUsernamesData> data { get; set; }
    }
    public class GetAllAdminUsernamesData
    {
        public string admin_id { get; set; }
    }
}
