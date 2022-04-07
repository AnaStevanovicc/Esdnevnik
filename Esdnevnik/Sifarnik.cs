﻿using System;
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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter Adapter;
        string ime_tabele;
        public Sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            string cs = "Data source = DESKTOP-UBL32UH; Initial catalog = ednevnik; Integrated security = true";
            SqlConnection veza = new SqlConnection(cs);
            Adapter = new SqlDataAdapter("Select * from " + ime_tabele, veza);
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (menjano != null)
            {
                Adapter.Update(menjano);
                this.Close();
            }
        }
    }
}