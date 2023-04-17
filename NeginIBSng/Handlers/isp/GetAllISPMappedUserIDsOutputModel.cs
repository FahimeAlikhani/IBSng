namespace NeginIBSng.Handlers.isp
{
    public class GetAllISPMappedUserIDsOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetAllISPMappedUserIDsResult result { get; set; }
        public string error { get; set; }
    }

    public class GetAllISPMappedUserIDsResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
