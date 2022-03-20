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
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable Tabela;
        public Osoba()
        {
            InitializeComponent();
        }

        private void Load_Data() 
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Osoba", veza);
            Tabela = new DataTable();
            adapter.Fill(Tabela);
        }

        private void Txt_Load()
        {
            if (Tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                btn_delete.Enabled = false;
            }
            else
            {
                txt_id.Text = Tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = Tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = Tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_adresa.Text = Tabela.Rows[broj_sloga]["adresa"].ToString();
                txt_jmbg.Text = Tabela.Rows[broj_sloga]["jmbg"].ToString();
                txt_email.Text = Tabela.Rows[broj_sloga]["email"].ToString();
                txt_pass.Text = Tabela.Rows[broj_sloga]["pass"].ToString();
                txt_uloga.Text = Tabela.Rows[broj_sloga]["uloga"].ToString();
                btn_delete.Enabled = true;
            }
            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else 
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (broj_sloga == Tabela.Rows.Count - 1)
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

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = Tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga)
            //VALUES('Marko', 'Lazic', 'Savska 10', '1234567891234', 'marko@gmail.com', '1234', 1)
            StringBuilder Naredba = new StringBuilder("INSERT INTO Osoba (ime, prezime, adresa, jmbg, email, pass, uloga)" +
                "VALUES('");
            Naredba.Append(txt_ime.Text + "', '");
            Naredba.Append(txt_prezime.Text + "', '");
            Naredba.Append(txt_adresa.Text + "', '");
            Naredba.Append(txt_jmbg.Text + "', '");
            Naredba.Append(txt_email.Text + "', '");
            Naredba.Append(txt_pass.Text + "', '");
            Naredba.Append(txt_uloga.Text + "')");
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
            Load_Data();
            broj_sloga = Tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //UPDATE Osoba set ime = 'Marko', prezime = 'Peric', adresa = 'Studenac 3',
            //jmbg = '12343', email = 'mpp@gmail.com', 'pass' = '123', uloga = 1
            //where id = 3
            StringBuilder Naredba = new StringBuilder("UPDATE Osoba set ");
            Naredba.Append("ime = '" + txt_ime.Text + "', ");
            Naredba.Append("prezime = '" + txt_prezime.Text + "', ");
            Naredba.Append("adresa = '" + txt_adresa.Text + "', ");
            Naredba.Append("jmbg = '" + txt_jmbg.Text + "', ");
            Naredba.Append("email = '" + txt_email.Text + "', ");
            Naredba.Append("pass = '" + txt_pass.Text + "', ");
            Naredba.Append("uloga = '" + txt_uloga.Text + "'");
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
            Load_Data();
            Txt_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Naredba = "Delete from Osoba where id = " + txt_id.Text;

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
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                Txt_Load();
            }
            

        }
    }
}
