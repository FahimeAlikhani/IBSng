namespace NeginIBSng.Handlers.admin
{
    public class DeleteAdminoutputModel :BaseModel
    {
        public int id { get; set; }
        public DeleteAdminResult result { get; set; }
        public string error { get; set; }
    }

    public class DeleteAdminResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
