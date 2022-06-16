using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Final_Proje.DL
{
    internal class MySqlCommand
    {
        private string v;
        private MySqlConnection conn;
        private MySqlConnection conn1;

        public MySqlCommand(string v, MySqlConnection conn)
        {
            this.v = v;
            this.conn = conn;
        }

        public MySqlCommand(string v, MySqlConnection conn1)
        {
            this.v = v;
            this.conn1 = conn1;
        }

        public CommandType CommandType { get; internal set; }
        public object Parameters { get; internal set; }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}