namespace NeginIBSng.Handlers.admin
{
    public class ChangePasswordoutputModel : BaseModel
    {
        public int id { get; set; }
        public ChangePasswordResult result { get; set; }
        public string error { get; set; }
    }

    public class ChangePasswordResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }

    }
}
