﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string dosya_yolu = "imla_kilavuzu.xlsx";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_yolu + ";Extended Properties=Excel 12.0");
            baglanti.Open();
            string sorgu = "select * from [Sheet1$] where a like '%" + textBox2.Text + "%'";
            OleDbDataAdapter data_adapter = new OleDbDataAdapter(sorgu, baglanti);
            baglanti.Close();

            DataTable dt = new DataTable();
            data_adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Lütfen Kelimeyi Girin!","Uyarı");
            }
            else
            {
                //string dosya_yolu = openFileDialog1.FileName;
                string dosya_yolu = "imla_kilavuzu.xlsx";
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_yolu + ";Extended Properties=Excel 12.0");
                baglanti.Open();
                string sorgu = "select * from [Sheet1$] where a like '%" + textBox2.Text + "%'";
                OleDbDataAdapter data_adapter = new OleDbDataAdapter(sorgu, baglanti);
                baglanti.Close();
                DataTable dt = new DataTable();
                data_adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        
    }
}
