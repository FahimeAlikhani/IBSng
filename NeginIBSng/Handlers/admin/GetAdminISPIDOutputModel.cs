namespace NeginIBSng.Handlers
{
    public class GetAdminISPIDOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetAdminISPIDResult result { get; set; }
        public string error { get; set; }
    }

    public class GetAdminISPIDResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetAdminISPIDData data { get; set; }
    }
    public class GetAdminISPIDData
    {
        public string isp_id { get; set; }
    }
}
