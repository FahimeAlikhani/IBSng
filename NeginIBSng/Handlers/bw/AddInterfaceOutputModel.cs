namespace NeginIBSng.Handlers.bw
{
    public class AddInterfaceOutputModel:BaseModel
    {
        public int id { get; set; }
        public AddInterfaceResult result { get; set; }
        public string error { get; set; }
    }

    public class AddInterfaceResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
