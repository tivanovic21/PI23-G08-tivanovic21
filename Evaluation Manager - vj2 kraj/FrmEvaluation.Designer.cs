namespace Evaluation_Manager
{
    partial class FrmEvaluation
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
            this.labelAktivnost = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.labelUvjetZaPotpis = new System.Windows.Forms.Label();
            this.labelUvjetZaOcjenu = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.labelOcjenjivac = new System.Windows.Forms.Label();
            this.labelDatumEvaluacije = new System.Windows.Forms.Label();
            this.labelBodovi = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAktivnost
            // 
            this.labelAktivnost.AutoSize = true;
            this.labelAktivnost.Location = new System.Drawing.Point(66, 33);
            this.labelAktivnost.Name = "labelAktivnost";
            this.labelAktivnost.Size = new System.Drawing.Size(54, 13);
            this.labelAktivnost.TabIndex = 0;
            this.labelAktivnost.Text = "Aktivnost:";
            this.labelAktivnost.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(69, 107);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(649, 203);
            this.txtActivityDescription.TabIndex = 1;
            // 
            // labelUvjetZaPotpis
            // 
            this.labelUvjetZaPotpis.AutoSize = true;
            this.labelUvjetZaPotpis.Location = new System.Drawing.Point(481, 31);
            this.labelUvjetZaPotpis.Name = "labelUvjetZaPotpis";
            this.labelUvjetZaPotpis.Size = new System.Drawing.Size(80, 13);
            this.labelUvjetZaPotpis.TabIndex = 2;
            this.labelUvjetZaPotpis.Text = "Uvjet za potpis:";
            // 
            // labelUvjetZaOcjenu
            // 
            this.labelUvjetZaOcjenu.AutoSize = true;
            this.labelUvjetZaOcjenu.Location = new System.Drawing.Point(618, 31);
            this.labelUvjetZaOcjenu.Name = "labelUvjetZaOcjenu";
            this.labelUvjetZaOcjenu.Size = new System.Drawing.Size(84, 13);
            this.labelUvjetZaOcjenu.TabIndex = 3;
            this.labelUvjetZaOcjenu.Text = "Uvjet za ocjenu:";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(482, 51);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(118, 20);
            this.txtMinForSignature.TabIndex = 4;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(623, 49);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(95, 20);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(69, 49);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(232, 21);
            this.cboActivities.TabIndex = 6;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // labelOcjenjivac
            // 
            this.labelOcjenjivac.AutoSize = true;
            this.labelOcjenjivac.Location = new System.Drawing.Point(356, 325);
            this.labelOcjenjivac.Name = "labelOcjenjivac";
            this.labelOcjenjivac.Size = new System.Drawing.Size(60, 13);
            this.labelOcjenjivac.TabIndex = 7;
            this.labelOcjenjivac.Text = "Ocjenjivač:";
            // 
            // labelDatumEvaluacije
            // 
            this.labelDatumEvaluacije.AutoSize = true;
            this.labelDatumEvaluacije.Location = new System.Drawing.Point(486, 325);
            this.labelDatumEvaluacije.Name = "labelDatumEvaluacije";
            this.labelDatumEvaluacije.Size = new System.Drawing.Size(92, 13);
            this.labelDatumEvaluacije.TabIndex = 8;
            this.labelDatumEvaluacije.Text = "Datum evaluacije:";
            // 
            // labelBodovi
            // 
            this.labelBodovi.AutoSize = true;
            this.labelBodovi.Location = new System.Drawing.Point(635, 325);
            this.labelBodovi.Name = "labelBodovi";
            this.labelBodovi.Size = new System.Drawing.Size(40, 13);
            this.labelBodovi.TabIndex = 9;
            this.labelBodovi.Text = "Bodovi";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(359, 341);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(112, 20);
            this.txtTeacher.TabIndex = 10;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(489, 341);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(127, 20);
            this.txtEvaluationDate.TabIndex = 11;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(639, 340);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(79, 20);
            this.numPoints.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(643, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.labelBodovi);
            this.Controls.Add(this.labelDatumEvaluacije);
            this.Controls.Add(this.labelOcjenjivac);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.labelUvjetZaOcjenu);
            this.Controls.Add(this.labelUvjetZaPotpis);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.labelAktivnost);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAktivnost;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label labelUvjetZaPotpis;
        private System.Windows.Forms.Label labelUvjetZaOcjenu;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label labelOcjenjivac;
        private System.Windows.Forms.Label labelDatumEvaluacije;
        private System.Windows.Forms.Label labelBodovi;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}