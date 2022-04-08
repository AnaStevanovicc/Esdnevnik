using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Esdnevnik
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int broj_sloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }

        private void Load_data()
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            ComboFill();

        }

        private void ComboFill()
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter;
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;
            dt_godina = new DataTable();
            adapter = new SqlDataAdapter("select * from Skolska_godina", veza);
            adapter.Fill(dt_godina);

            dt_nastavnik = new DataTable();
            adapter = new SqlDataAdapter("select id, ime + prezime as naziv from Osoba where uloga =2 ", veza);
            adapter.Fill(dt_nastavnik);

            dt_predmet = new DataTable();
            adapter = new SqlDataAdapter("select id, naziv from Predmet", veza);
            adapter.Fill(dt_predmet);

            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("select id, STR(razred) + '-' + indeks as naziv from Odeljenje", veza);
            adapter.Fill(dt_odeljenje);

            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];


            cmb_nastavnik.DataSource = dt_nastavnik;
            cmb_nastavnik.ValueMember = "id";
            cmb_nastavnik.DisplayMember = "naziv";
            cmb_nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];


            cmb_predmet.DataSource = dt_predmet;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            cmb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];


            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
            cmb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];

            txt_id.Text = raspodela.Rows[broj_sloga]["id"].ToString();

            if (raspodela.Rows.Count == 0)
            {
                cmb_godina.SelectedValue = -1;
                cmb_nastavnik.SelectedValue = -1;
                cmb_predmet.SelectedValue = -1;
                cmb_odeljenje.SelectedValue = -1;

            }
            else
            {
                cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];
                cmb_nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];
                cmb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];
                cmb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];
            }

            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_previous.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_previous.Enabled = true;
            }

            if (broj_sloga == raspodela.Rows.Count - 1)
            {
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            ComboFill();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            ComboFill();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            ComboFill();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string Naredba = "Delete from Raspodela where id = " + txt_id.Text;

            SqlConnection veza = new SqlConnection("Data source = DESKTOP-UBL32UH; Initial catalog = ednevnik; Integrated security = true; MultipleActiveResultSets=true");
            SqlCommand Komanda = new SqlCommand(Naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                Load_data();
                if (broj_sloga > 0) broj_sloga--;
                ComboFill();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO Raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id)" +
            "VALUES('");
            Naredba.Append(cmb_godina.SelectedValue + "', '");
            Naredba.Append(cmb_nastavnik.SelectedValue + "', '");
            Naredba.Append(cmb_predmet.SelectedValue + "', '");
            Naredba.Append(cmb_odeljenje.SelectedValue  + "')");
            SqlConnection veza = new SqlConnection("Data source = DESKTOP-UBL32UH; Initial catalog = ednevnik; Integrated security = true");
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_data();
            broj_sloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE Raspodela set ");
            Naredba.Append("godina_id = '" + cmb_godina.SelectedValue + "', ");
            Naredba.Append("nastavnik_id = '" + cmb_nastavnik.SelectedValue + "', ");
            Naredba.Append("predmet_id = '" + cmb_predmet.SelectedValue + "', ");
            Naredba.Append("odeljenje_id = '" + cmb_odeljenje.SelectedValue + "'");
            Naredba.Append("where id = " + txt_id.Text);

            SqlConnection veza = new SqlConnection("Data source = DESKTOP-UBL32UH; Initial catalog = ednevnik; Integrated security = true");
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_data();
            ComboFill();
        }
    }
}
