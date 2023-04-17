namespace NeginIBSng.Handlers.admin
{
    public class UpdateAdminInfoOutputModel : BaseModel
    {
        public int id { get; set; }
        public UpdateAdminInfoResult result { get; set; }
        public string error { get; set; }
    }

    public class UpdateAdminInfoResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
