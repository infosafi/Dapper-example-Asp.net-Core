using System.Data;

namespace Dapper_example.Repository.Helper
{
    [Serializable]
    public class SPParameters
    {
        public string _Comcod { get; set; }
        public string StoredProcedure { get; set; }
        public string Calltype { get; set; }
        public DataSet Dxml01 { get; set; }
        public DataSet Dxml02 { get; set; }
        public byte[] Dbin01 { get; set; }
        public string Desc01 { get; set; }
        public string Desc02 { get; set; }
        public string Desc03 { get; set; }
        public string Desc04 { get; set; }
        public string Desc05 { get; set; }
        public string Desc06 { get; set; }
        public string Desc07 { get; set; }
        public string Desc08 { get; set; }
        public string Desc09 { get; set; }
        public string Desc10 { get; set; }
        public string Desc11 { get; set; }
        public string Desc12 { get; set; }
        public string Desc13 { get; set; }
        public string Desc14 { get; set; }
        public string Desc15 { get; set; }
        public string Desc16 { get; set; }
        public string Desc17 { get; set; }
        public string Desc18 { get; set; }
        public string Desc19 { get; set; }
        public string Desc20 { get; set; }
        public string Desc21 { get; set; }
        public string Desc22 { get; set; }
        public string Desc23 { get; set; }
        public string Desc24 { get; set; }
        public string Desc25 { get; set; }
        public string Desc26 { get; set; }
        public string Desc27 { get; set; }
        public string Desc28 { get; set; }
        public string Desc29 { get; set; }
        public string Desc30 { get; set; }
        public string Desc31 { get; set; }
        public string Desc32 { get; set; }
        public string Desc33 { get; set; }
        public string Desc34 { get; set; }
        public string Desc35 { get; set; }
        public string Desc36 { get; set; }
        public string Desc37 { get; set; }
        public string Desc38 { get; set; }
        public string Desc39 { get; set; }
        public string Desc40 { get; set; }
        public string Desc41 { get; set; }
        public string Desc42 { get; set; }
        public string Desc43 { get; set; }
        public string Desc44 { get; set; }
        public string Desc45 { get; set; }
        public string Desc46 { get; set; }
        public string Desc47 { get; set; }
        public string Desc48 { get; set; }
        public string Desc49 { get; set; }
        public string Desc50 { get; set; }

        public string UserID { get; set; }

        public SPParameters()
        {

        }
        public SPParameters(string _Comcod = "", string _StoredProcedure = "", string _CallType = "", DataSet _Dxml01 = null, DataSet _Dxml02 = null, byte[] _Dbin01 = null, string _Desc01 = "", string _Desc02 = "",
            string _Desc03 = "", string _Desc04 = "", string _Desc05 = "", string _Desc06 = "", string _Desc07 = "", string _Desc08 = "", string _Desc09 = "", string _Desc10 = "", string _Desc11 = "",
                string _Desc12 = "", string _Desc13 = "", string _Desc14 = "", string _Desc15 = "", string _Desc16 = "", string _Desc17 = "", string _Desc18 = "", string _Desc19 = "", string _Desc20 = "",
                    string _Desc21 = "", string _Desc22 = "", string _Desc23 = "",
                    string _Desc24 = "", string _Desc25 = "",
                     string _Desc26 = "", string _Desc27 = "", string _Desc28 = "",
                      string _Desc29 = "", string _Desc30 = "", string _Desc31 = "",
                       string _Desc32 = "", string _Desc33 = "", string _Desc34 = "",
                        string _Desc35 = "", string _Desc36 = "", string _Desc37 = "",
                         string _Desc38 = "", string _Desc39 = "", string _Desc40 = "",
                          string _Desc41 = "", string _Desc42 = "", string _Desc43 = "",
                           string _Desc44 = "", string _Desc45 = "", string _Desc46 = "",
                            string _Desc47 = "", string _Desc48 = "", string _Desc49 = "",
                            string _Desc50="",string _UserID = "")
        {
            this._Comcod = _Comcod;
            StoredProcedure = _StoredProcedure;
            Calltype = _CallType;
            Dxml01 = _Dxml01;
            Dxml02 = _Dxml02;
            Dbin01 = _Dbin01;
            Desc01 = _Desc01;
            Desc02 = _Desc02;
            Desc03 = _Desc03;
            Desc04 = _Desc04;
            Desc05 = _Desc05;
            Desc06 = _Desc06;
            Desc07 = _Desc07;
            Desc08 = _Desc08;
            Desc09 = _Desc09;
            Desc10 = _Desc10;
            Desc11 = _Desc11;
            Desc12 = _Desc12;
            Desc13 = _Desc13;
            Desc14 = _Desc14;
            Desc15 = _Desc15;
            Desc16 = _Desc16;
            Desc17 = _Desc17;
            Desc18 = _Desc18;
            Desc19 = _Desc19;
            Desc20 = _Desc20;
            Desc21 = _Desc21;
            Desc22 = _Desc22;
            Desc23 = _Desc23;
            Desc24 = _Desc24;
            Desc25 = _Desc25;
            Desc26 = _Desc26;
            Desc27 = _Desc27;
            Desc28 = _Desc28;
            Desc29 = _Desc29;
            Desc30 = _Desc30;
            Desc31 = _Desc31;
            Desc32 = _Desc32;
            Desc33 = _Desc33;
            Desc34 = _Desc34;
            Desc35 = _Desc35;
            Desc36 = _Desc36;
            Desc37 = _Desc37;
            Desc38 = _Desc38;
            Desc39 = _Desc39;
            Desc40 = _Desc40;
            Desc41 = _Desc41;
            Desc42 = _Desc42;
            Desc43 = _Desc43;
            Desc44 = _Desc44;
            Desc45 = _Desc45;
            Desc46 = _Desc46;
            Desc47 = _Desc47;
            Desc48 = _Desc48;
            Desc49 = _Desc49;
            Desc50 = _Desc50;
            UserID = _UserID;
        }
    }
}
