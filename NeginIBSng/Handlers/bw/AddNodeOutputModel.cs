namespace NeginIBSng.Handlers.bw
{
    public class AddNodeOutputModel :BaseModel
    {
        public int id { get; set; }
        public AddNodeResult result { get; set; }
        public string error { get; set; }
    }

    public class AddNodeResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
