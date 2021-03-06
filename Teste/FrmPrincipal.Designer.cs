﻿namespace TesteWebService
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrlServidorJavaEE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxOpcaoTeste = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTestar = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.BwProcesso = new System.ComponentModel.BackgroundWorker();
            this.LblTeste = new System.Windows.Forms.Label();
            this.LnkSeniorDeployTool = new System.Windows.Forms.LinkLabel();
            this.LnkPainelPadraoGlassfish = new System.Windows.Forms.LinkLabel();
            this.LnkSolucaoBase = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL do servidor Java EE";
            // 
            // TxtUrlServidorJavaEE
            // 
            this.TxtUrlServidorJavaEE.Location = new System.Drawing.Point(16, 26);
            this.TxtUrlServidorJavaEE.Name = "TxtUrlServidorJavaEE";
            this.TxtUrlServidorJavaEE.Size = new System.Drawing.Size(316, 20);
            this.TxtUrlServidorJavaEE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opção de Teste";
            // 
            // CbxOpcaoTeste
            // 
            this.CbxOpcaoTeste.FormattingEnabled = true;
            this.CbxOpcaoTeste.Items.AddRange(new object[] {
            "01 - Integração Financeira",
            "02 - Integração Contabil",
            "03 - Integração Fornecedor",
            "04 - Integração Pesquisa",
            "05 - Integração Centro de Custo",
            "06 - Ronda Senior"});
            this.CbxOpcaoTeste.Location = new System.Drawing.Point(6, 32);
            this.CbxOpcaoTeste.Name = "CbxOpcaoTeste";
            this.CbxOpcaoTeste.Size = new System.Drawing.Size(304, 21);
            this.CbxOpcaoTeste.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxOpcaoTeste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BtnTestar
            // 
            this.BtnTestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestar.Location = new System.Drawing.Point(626, 14);
            this.BtnTestar.Name = "BtnTestar";
            this.BtnTestar.Size = new System.Drawing.Size(142, 42);
            this.BtnTestar.TabIndex = 5;
            this.BtnTestar.Text = "Testar";
            this.BtnTestar.UseVisualStyleBackColor = false;
            this.BtnTestar.Click += new System.EventHandler(this.BtnTestar_Click);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.AllowUserToOrderColumns = true;
            this.DgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.URL,
            this.Erro});
            this.DgvLista.Location = new System.Drawing.Point(13, 153);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.Size = new System.Drawing.Size(755, 244);
            this.DgvLista.TabIndex = 6;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Check.Width = 44;
            // 
            // URL
            // 
            this.URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Width = 54;
            // 
            // Erro
            // 
            this.Erro.HeaderText = "Erro";
            this.Erro.Name = "Erro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL Testadas";
            // 
            // BwProcesso
            // 
            this.BwProcesso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwProcesso_DoWork);
            this.BwProcesso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwProcesso_RunWorkerCompleted);
            // 
            // LblTeste
            // 
            this.LblTeste.AutoSize = true;
            this.LblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTeste.Location = new System.Drawing.Point(338, 61);
            this.LblTeste.Name = "LblTeste";
            this.LblTeste.Size = new System.Drawing.Size(31, 29);
            this.LblTeste.TabIndex = 9;
            this.LblTeste.Text = "...";
            // 
            // LnkSeniorDeployTool
            // 
            this.LnkSeniorDeployTool.AutoSize = true;
            this.LnkSeniorDeployTool.Location = new System.Drawing.Point(671, 137);
            this.LnkSeniorDeployTool.Name = "LnkSeniorDeployTool";
            this.LnkSeniorDeployTool.Size = new System.Drawing.Size(97, 13);
            this.LnkSeniorDeployTool.TabIndex = 10;
            this.LnkSeniorDeployTool.TabStop = true;
            this.LnkSeniorDeployTool.Text = "Senior Deploy Tool";
            this.LnkSeniorDeployTool.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSeniorDeployTool_LinkClicked);
            // 
            // LnkPainelPadraoGlassfish
            // 
            this.LnkPainelPadraoGlassfish.AutoSize = true;
            this.LnkPainelPadraoGlassfish.Location = new System.Drawing.Point(650, 119);
            this.LnkPainelPadraoGlassfish.Name = "LnkPainelPadraoGlassfish";
            this.LnkPainelPadraoGlassfish.Size = new System.Drawing.Size(118, 13);
            this.LnkPainelPadraoGlassfish.TabIndex = 11;
            this.LnkPainelPadraoGlassfish.TabStop = true;
            this.LnkPainelPadraoGlassfish.Text = "Painel Padrão Glassfish";
            this.LnkPainelPadraoGlassfish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPainelPadraoGlassfish_LinkClicked);
            // 
            // LnkSolucaoBase
            // 
            this.LnkSolucaoBase.AutoSize = true;
            this.LnkSolucaoBase.Location = new System.Drawing.Point(656, 103);
            this.LnkSolucaoBase.Name = "LnkSolucaoBase";
            this.LnkSolucaoBase.Size = new System.Drawing.Size(112, 13);
            this.LnkSolucaoBase.TabIndex = 12;
            this.LnkSolucaoBase.TabStop = true;
            this.LnkSolucaoBase.Text = "Solução Base - 16186";
            this.LnkSolucaoBase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSolucaoBase_LinkClicked);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 406);
            this.Controls.Add(this.LnkSolucaoBase);
            this.Controls.Add(this.LnkPainelPadraoGlassfish);
            this.Controls.Add(this.LnkSeniorDeployTool);
            this.Controls.Add(this.LblTeste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnTestar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtUrlServidorJavaEE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de WebServices";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrlServidorJavaEE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxOpcaoTeste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnTestar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erro;
        private System.ComponentModel.BackgroundWorker BwProcesso;
        private System.Windows.Forms.Label LblTeste;
        private System.Windows.Forms.LinkLabel LnkSeniorDeployTool;
        private System.Windows.Forms.LinkLabel LnkPainelPadraoGlassfish;
        private System.Windows.Forms.LinkLabel LnkSolucaoBase;
    }
}

