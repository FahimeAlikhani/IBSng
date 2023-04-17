namespace NeginIBSng.Handlers.isp
{
    public class GetISPPageStyleOutputModel :BaseModel
    {
        public int id { get; set; }
        public GetISPPageStyleResult result { get; set; }
        public string error { get; set; }
    }

    public class GetISPPageStyleResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public GetISPPageStyleData Data { get; set; }
    }
    public class GetISPPageStyleData
    {
        public int isp_id { get; set; }
        public string header_logo_ext { get; set; }
        public string header_logo_contents { get; set; }
        public string header_bg_color { get; set; }
        public string header_text_color { get; set; }
        public string footer_logo_ext { get; set; }
        public string footer_logo_contents { get; set; }
        public string footer_bg_color { get; set; }
        public string footer_text_color { get; set; }
        public string footer_msg { get; set; }
    }
}
