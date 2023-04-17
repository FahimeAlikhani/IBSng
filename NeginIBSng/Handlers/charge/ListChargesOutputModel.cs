namespace NeginIBSng.Handlers.charge
{
    public class Extra_ChargeOutputModel : BaseModel
        {
            public int id { get; set; }
            public Extra_ChargeResult result { get; set; }
            public string error { get; set; }
        }

        public class Extra_ChargeResult
    {
            public int errcode { get; set; }
            public string errmsg { get; set; }
           
        }
    }
