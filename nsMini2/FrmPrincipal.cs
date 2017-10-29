using System;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace nsMini2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void NS_MINI()
        {
            DateTime fechaMomento = DateTime.Now;
            DateTime fechaDeHoy = DateTime.Today;
            double contestadas = LlamadasContestadas(fechaMomento);
            double abandonadas = LlamadasAbandonadas(fechaMomento);
            double transferidasivr = LlamadasTransferidasIVR(fechaMomento);
            double contestadasd20S = LlamadasContestadasD20Seg(fechaDeHoy);
            double abandonadasd20S = LlamadasAbandonadasD20Seg(fechaDeHoy);
            double totalrecibidas = TotalLlamadasRecibidas(fechaMomento);

            txtRecibidas.Text = totalrecibidas.ToString(CultureInfo.InvariantCulture);
            txtContestadas.Text = (contestadas + transferidasivr).ToString(CultureInfo.InvariantCulture);
            txtContestadasD20Seg.Text = contestadasd20S.ToString(CultureInfo.InvariantCulture);
            txtAbandonadas.Text = abandonadas.ToString(CultureInfo.InvariantCulture);
            txtAbandonadasD20Seg.Text = abandonadasd20S.ToString(CultureInfo.InvariantCulture);

            var recibidas = contestadas + abandonadas + transferidasivr;
            var fueradeobjetivo = contestadasd20S + abandonadasd20S;
            var nivelservicio = nivelDeServicio(recibidas, fueradeobjetivo);

            lbNS_Actual.Text = $@"{Math.Round(nivelservicio, 2)} %";
        }


        #region Mis Metodos

        private int LlamadasContestadas(DateTime fecha)
        {
            using (var conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT(DISTINCT(callid)) AS `Total Llamadas Contestadas` FROM asterisk.queue_log
                                      WHERE `time` BETWEEN @inicio AND @fin
                                      AND DAYNAME(`time`) NOT IN('Saturday', 'Sunday')
                                      AND `event` IN('CONNECT')
                                      AND callid IN(SELECT uniqueid FROM cdr);";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);
                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 07, 50, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 18, 00, 00);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }

                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }

        private int LlamadasContestadasD20Seg(DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT((callid)) AS `Total Llamadas Contestadas D20 Seg` FROM asterisk.queue_log
                                      WHERE `time` BETWEEN @inicio AND @fin
                                      AND DAYNAME(`time`) NOT IN('Saturday', 'Sunday')
                                      AND `event` IN('CONNECT')
                                      AND data1 >= 20
                                      AND callid IN (SELECT uniqueid FROM asterisk.cdr);";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);

                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 07, 50, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 18, 00, 00);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }
                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }

        private int LlamadasAbandonadas(DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT(callid) AS `Llamadas Abandonadas` FROM asterisk.queue_log
                                      WHERE `time` BETWEEN @inicio AND @fin
                                      AND DAYNAME(`time`) NOT IN('Saturday', 'Sunday')
                                      AND `event` IN('ABANDON')
                                      AND callid IN (SELECT uniqueid FROM asterisk.cdr);";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);
                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 07, 50, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 18, 00, 00);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }
                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }

        private int LlamadasAbandonadasD20Seg(DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT(callid) AS `Llamadas Abandonadas` FROM asterisk.queue_log
                                    WHERE `time` BETWEEN @inicio AND @fin
                                    AND `event` IN('ABANDON')
                                    AND data3 >= 20
                                    AND callid IN (SELECT uniqueid FROM asterisk.cdr);";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);

                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 07, 50, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 18, 00, 00);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }
                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }

        private int TotalLlamadasRecibidas(DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT(DISTINCT(uniqueid)) AS `Llamadas Recibidas Dia Completo` FROM asterisk.cdr
                                WHERE calldate BETWEEN @inicio AND @fin
                                AND dst NOT IN('8099080311')
                                AND (dcontext = 'CCG' OR dcontext = 'SIP-CCG');";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);

                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 00, 00, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }
                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }

        private double LlamadasTransferidasIVR(DateTime fecha)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = Cadena.CadenaDeConexion;

                const string mySqlQuery = @"SELECT COUNT(uniqueid) `Llamadas Transferidas por IVR` FROM asterisk.cdr
                                    WHERE calldate BETWEEN @inicio AND @fin
                                    AND (dcontext = 'CCG' OR dcontext = 'SIP-CCG')
                                    AND dst NOT IN('FHora', '8099080311')
                                    AND userfield = ''
                                    AND lastapp IN ('Dial')
                                    AND uniqueid NOT IN (SELECT callid FROM asterisk.queue_log);";

                MySqlCommand cmd = new MySqlCommand(mySqlQuery, conn);

                cmd.Parameters.Add("@inicio", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 00, 00, 00);
                cmd.Parameters.Add("@fin", MySqlDbType.DateTime).Value = new DateTime(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59);

                cmd.CommandTimeout = 900;

                if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Convert.ToInt32(0.00);
                }
                conn.Open();
                var totalLlamadas = cmd.ExecuteScalar();
                conn.Close();

                return Convert.ToInt32(totalLlamadas);
            }
        }


        #endregion

        #region Controles

        private void Limpieza()
        {
            txtContestadas.Clear();
            txtAbandonadas.Clear();
            txtContestadasD20Seg.Clear();
            txtAbandonadasD20Seg.Clear();
            txtRecibidas.Clear();
            lbNS_Actual.Text = null;
        }


        #endregion

        #region Calculos del Nivel de Servicio

        private double nivelDeServicio(double recibidas, double fueraDeObjetivo)
        {
            double ns = ((recibidas - fueraDeObjetivo) / recibidas) * 100;
            return ns;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpieza();
            NS_MINI();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NS_MINI();
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NS_MINI();
        }

    }
}
