namespace NeginIBSng.Handlers.extra_charge
{
    public class UpdateExtraChargeProfileOutputModel : BaseModel
        {
            public int id { get; set; }
            public AddExtraChargeProfile result { get; set; }
            public string error { get; set; }
        }

        public class UpdateExtraChargeProfile
    {
            public int errcode { get; set; }
            public string errmsg { get; set; }
        }
    }
