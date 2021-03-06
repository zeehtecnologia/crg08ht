﻿namespace CRG08.View
{
    partial class LogMudanca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogMudanca));
            this.diaFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.diaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.dtgErros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.SuspendLayout();
            // 
            // diaFim
            // 
            this.diaFim.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.diaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.diaFim, "");
            this.helpProvider1.SetHelpString(this.diaFim, "Log de mudança entre datas específicas.");
            this.diaFim.Location = new System.Drawing.Point(127, 3);
            this.diaFim.Name = "diaFim";
            this.helpProvider1.SetShowHelp(this.diaFim, true);
            this.diaFim.Size = new System.Drawing.Size(81, 20);
            this.diaFim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label2, "");
            this.helpProvider1.SetHelpString(this.label2, "Log de mudança entre datas específicas.");
            this.label2.Location = new System.Drawing.Point(113, 9);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "a ";
            // 
            // diaInicio
            // 
            this.diaInicio.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.diaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.diaInicio, "");
            this.helpProvider1.SetHelpString(this.diaInicio, "Log de mudança entre datas específicas.");
            this.diaInicio.Location = new System.Drawing.Point(30, 3);
            this.diaInicio.Name = "diaInicio";
            this.helpProvider1.SetShowHelp(this.diaInicio, true);
            this.diaInicio.Size = new System.Drawing.Size(82, 20);
            this.diaInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label1, "");
            this.helpProvider1.SetHelpString(this.label1, "Log de mudança entre datas específicas.");
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "De: ";
            // 
            // Imprimir
            // 
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpProvider1.SetHelpKeyword(this.Imprimir, "");
            this.helpProvider1.SetHelpString(this.Imprimir, "Imprime lista de log de mudança.");
            this.Imprimir.Location = new System.Drawing.Point(381, 298);
            this.Imprimir.Name = "Imprimir";
            this.helpProvider1.SetShowHelp(this.Imprimir, true);
            this.Imprimir.Size = new System.Drawing.Size(75, 23);
            this.Imprimir.TabIndex = 3;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // Sair
            // 
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpProvider1.SetHelpKeyword(this.Sair, "");
            this.helpProvider1.SetHelpString(this.Sair, "Sai da função log de Mudança.");
            this.Sair.Location = new System.Drawing.Point(462, 298);
            this.Sair.Name = "Sair";
            this.helpProvider1.SetShowHelp(this.Sair, true);
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // dtgErros
            // 
            this.dtgErros.AllowUserToAddRows = false;
            this.dtgErros.AllowUserToDeleteRows = false;
            this.dtgErros.BackgroundColor = System.Drawing.Color.White;
            this.dtgErros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DataHora,
            this.DMC,
            this.Descricao,
            this.Detalhes});
            this.helpProvider1.SetHelpKeyword(this.dtgErros, "");
            this.helpProvider1.SetHelpString(this.dtgErros, "Lista de logs de mudança.");
            this.dtgErros.Location = new System.Drawing.Point(11, 33);
            this.dtgErros.Name = "dtgErros";
            this.dtgErros.ReadOnly = true;
            this.dtgErros.RowHeadersVisible = false;
            this.helpProvider1.SetShowHelp(this.dtgErros, true);
            this.dtgErros.Size = new System.Drawing.Size(526, 249);
            this.dtgErros.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // DataHora
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataHora.HeaderText = "Data/Hora";
            this.DataHora.Name = "DataHora";
            this.DataHora.ReadOnly = true;
            this.DataHora.Width = 130;
            // 
            // DMC
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DMC.DefaultCellStyle = dataGridViewCellStyle2;
            this.DMC.HeaderText = "CRG";
            this.DMC.Name = "DMC";
            this.DMC.ReadOnly = true;
            this.DMC.Width = 35;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Detalhes
            // 
            this.Detalhes.HeaderText = "Responsável";
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalhes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Search
            // 
            this.helpProvider1.SetHelpKeyword(this.Search, "");
            this.helpProvider1.SetHelpString(this.Search, "Função de localização dos logs de mudança.");
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(214, 3);
            this.Search.Name = "Search";
            this.helpProvider1.SetShowHelp(this.Search, true);
            this.Search.Size = new System.Drawing.Size(24, 20);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 47;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LogMudanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 333);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.diaFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.dtgErros);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogMudanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Mudança";
            this.Load += new System.EventHandler(this.LogMudanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.DateTimePicker diaFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker diaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.DataGridView dtgErros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalhes;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}