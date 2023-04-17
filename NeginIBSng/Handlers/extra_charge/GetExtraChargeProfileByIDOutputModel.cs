namespace NeginIBSng.Handlers.extra_charge
{
    public class GetExtraChargeProfileByIDOutputModel : BaseModel
        {
            public int id { get; set; }
            public GetExtraChargeProfileByIDResult result { get; set; }
            public string error { get; set; }
        }

        public class GetExtraChargeProfileByIDResult
        {
            public int errcode { get; set; }
            public string errmsg { get; set; }
            public List<Items> item { get; set; }
        }
    }
