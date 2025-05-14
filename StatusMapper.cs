namespace DotnetWeathertopJsonReporter
{
    public static class StatusMapper
    {
        public static string MapToCtrfStatus(string nunitStatus)
        {
            return nunitStatus switch
            {
                "Passed" => "passed",
                "Failed" => "failed",
                _ => "other"
            };
        }
    }
}
