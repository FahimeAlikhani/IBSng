namespace NeginIBSng.Handlers.isp
{   
    public class ResetISPPageStyleOutputModel:BaseModel
    {
        public int id { get; set; }
        public ResetISPPageStyleResult result { get; set; }
        public string error { get; set; }
    }

    public class ResetISPPageStyleResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
