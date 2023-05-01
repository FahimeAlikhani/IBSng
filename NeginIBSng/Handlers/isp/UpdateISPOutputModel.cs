using NeginIBSng.Handlers.admin;

namespace NeginIBSng.Handlers.isp
{
    public class HasPermOutputModel :BaseModel
    {
        public Result result { get; set; }
        public string error { get; set; }
    }


}
