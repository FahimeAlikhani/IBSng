namespace NeginIBSng.Handlers.isp
{
    public class AddNewISPOutputModel :BaseModel
    {
        public int id { get; set; }
        public AddNewISPResult result { get; set; }
        public string error { get; set; }
    }

    public class AddNewISPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
