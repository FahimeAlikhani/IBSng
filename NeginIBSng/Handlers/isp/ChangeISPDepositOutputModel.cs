namespace NeginIBSng.Handlers.isp
{
    public class ChangeISPDepositOutputModel :BaseModel
    {
        public int id { get; set; }
        public ChangeISPDepositResult result { get; set; }
        public string error { get; set; }
    }

    public class ChangeISPDepositResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
