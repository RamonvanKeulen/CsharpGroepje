using System;
using System.Data;
using System.Collections.Generic;
using System.Web;

namespace FirstPlaylist.App_Code
{
    public class SongMethods
    {
        public string file = "playlist.xml";
        public DataSet ds = null;

        public DataSet GetAllSongs()
        {
            if (ds == null)
            { 
                ds = new DataSet("playlist");

            DataTable songs = new DataTable("song");

            DataTable title = new DataTable("title");
            DataTable artist = new DataTable("artist");
            DataTable album = new DataTable("album");
            DataTable year = new DataTable("year");
            DataTable length = new DataTable("length");
            DataTable pfile = new DataTable("file");

            ds.ReadXml(HttpContext.Current.Server.MapPath(file));
            }
            return ds;
        }

        public DataRow GetEmptyRow()
        {
            return ds.Tables["song"].NewRow();
        }

        public void SaveRow(DataRow dr)
        {
            ds.Tables["song"].Rows.Add(dr);
            ds.WriteXml(HttpContext.Current.Server.MapPath(file));
        }
        
    }
}