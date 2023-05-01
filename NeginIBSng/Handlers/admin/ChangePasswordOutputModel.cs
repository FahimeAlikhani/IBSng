namespace NeginIBSng.Handlers.admin
{
    public class ChangePasswordoutputModel : BaseModel
    {
        public Result result { get; set; }
        public string error { get; set; }
    }

    public class Result
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }

    }
}
