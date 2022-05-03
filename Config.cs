namespace MediaDB
{
    static class Config
    {
        static string LocalPath = "C:\\Users\\Robert\\OneDrive\\Documents\\School\\cSharp2\\MediaDB";
        //public static string Relative = "[DataDirectory]";

        public static string ConString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
                                         "[DataDirectory]\\media.mdf;" +
                                         "Integrated Security = True; Connect Timeout = 30";
    }
}
