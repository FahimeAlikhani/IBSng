namespace NeginIBSng.Handlers.isp
{
    public class SetISPPageStyleOutputModel :BaseModel
    {
        public int id { get; set; }
        public SetISPPageStyleResult result { get; set; }
        public string error { get; set; }
    }

    public class SetISPPageStyleResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
