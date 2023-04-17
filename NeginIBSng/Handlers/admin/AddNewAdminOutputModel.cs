namespace NeginIBSng.Handlers
{
    public class AddNewAdminoutputModel : BaseModel
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
        public int admin_id { get; set; }
    }
}
