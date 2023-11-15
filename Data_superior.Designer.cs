namespace Ejecicios_del_Gym
{
    partial class Data_superior
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
            this.data_superior_1 = new System.Windows.Forms.DataGridView();
            this.collunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coljue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.com_lunes = new System.Windows.Forms.ComboBox();
            this.com_martes = new System.Windows.Forms.ComboBox();
            this.com_jueves = new System.Windows.Forms.ComboBox();
            this.com_miercoles = new System.Windows.Forms.ComboBox();
            this.com_sabado = new System.Windows.Forms.ComboBox();
            this.com_viernes = new System.Windows.Forms.ComboBox();
            this.com_domingo = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.col_saba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_domi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_superior_1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_superior_1
            // 
            this.data_superior_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data_superior_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_superior_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collunes,
            this.colmar,
            this.colmier,
            this.coljue,
            this.colvier,
            this.col_saba,
            this.col_domi});
            this.data_superior_1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data_superior_1.Location = new System.Drawing.Point(65, 238);
            this.data_superior_1.Name = "data_superior_1";
            this.data_superior_1.Size = new System.Drawing.Size(732, 200);
            this.data_superior_1.TabIndex = 0;
            this.data_superior_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_superior_1_CellContentClick);
            // 
            // collunes
            // 
            this.collunes.HeaderText = "Lunes";
            this.collunes.Name = "collunes";
            // 
            // colmar
            // 
            this.colmar.HeaderText = "Martes";
            this.colmar.Name = "colmar";
            // 
            // colmier
            // 
            this.colmier.HeaderText = "Miércoles";
            this.colmier.Name = "colmier";
            // 
            // coljue
            // 
            this.coljue.HeaderText = "Jueves";
            this.coljue.Name = "coljue";
            // 
            // colvier
            // 
            this.colvier.HeaderText = "Viernes";
            this.colvier.Name = "colvier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lunes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Martes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Miércoles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jueves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Viernes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sábado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Domingo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(365, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tren Superior";
            // 
            // com_lunes
            // 
            this.com_lunes.FormattingEnabled = true;
            this.com_lunes.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_lunes.Location = new System.Drawing.Point(65, 7);
            this.com_lunes.Name = "com_lunes";
            this.com_lunes.Size = new System.Drawing.Size(203, 21);
            this.com_lunes.TabIndex = 16;
            // 
            // com_martes
            // 
            this.com_martes.FormattingEnabled = true;
            this.com_martes.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_martes.Location = new System.Drawing.Point(65, 36);
            this.com_martes.Name = "com_martes";
            this.com_martes.Size = new System.Drawing.Size(203, 21);
            this.com_martes.TabIndex = 17;
            // 
            // com_jueves
            // 
            this.com_jueves.FormattingEnabled = true;
            this.com_jueves.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_jueves.Location = new System.Drawing.Point(65, 103);
            this.com_jueves.Name = "com_jueves";
            this.com_jueves.Size = new System.Drawing.Size(202, 21);
            this.com_jueves.TabIndex = 19;
            // 
            // com_miercoles
            // 
            this.com_miercoles.FormattingEnabled = true;
            this.com_miercoles.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_miercoles.Location = new System.Drawing.Point(65, 74);
            this.com_miercoles.Name = "com_miercoles";
            this.com_miercoles.Size = new System.Drawing.Size(202, 21);
            this.com_miercoles.TabIndex = 18;
            // 
            // com_sabado
            // 
            this.com_sabado.FormattingEnabled = true;
            this.com_sabado.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_sabado.Location = new System.Drawing.Point(65, 161);
            this.com_sabado.Name = "com_sabado";
            this.com_sabado.Size = new System.Drawing.Size(202, 21);
            this.com_sabado.TabIndex = 21;
            // 
            // com_viernes
            // 
            this.com_viernes.FormattingEnabled = true;
            this.com_viernes.Items.AddRange(new object[] {
            "Press de banca con barra",
            "Flexiones",
            "Press de banca inclinado",
            "Pull-over con mancuerna",
            "Flexiones de diamante",
            "Aperturas con mancuernas",
            "Fondos en paralelas",
            "Press de banca declinado",
            "Pec Deck Machine",
            "Aperturas inclinadas con mancuernas",
            "Press militar con barra",
            "Elevaciones laterales con mancuernas",
            "Press de hombros con mancuernas",
            "Pájaros con mancuernas",
            "Elevaciones frontales con barra",
            "Face pulls",
            "Press Arnold",
            "Elevaciones laterales en máquina",
            "Press de hombros con barra tras nuca",
            "Shrugs con barra o mancuerna",
            "Fondos en paralelas",
            "Press de tríceps en polea alta",
            "Fondos en máquina dip",
            "Extensiones de tríceps con barra",
            "Fondos en banco",
            "Press francés con barra EZ",
            "Extensiones de tríceps con mancuerna",
            "Rompecráneos con barra",
            "Pulldown de tríceps en polea alta",
            "Fondos en máquina de tríceps",
            "Pull-ups",
            "Dominadas",
            "Remo con barra",
            "Pulldown en polea alta",
            "Remo con mancuerna",
            "Peso muerto",
            "Pull-over con mancuerna",
            "Hiperextensiones",
            "Face pulls con polea",
            "Pulldown en polea baja"});
            this.com_viernes.Location = new System.Drawing.Point(65, 134);
            this.com_viernes.Name = "com_viernes";
            this.com_viernes.Size = new System.Drawing.Size(202, 21);
            this.com_viernes.TabIndex = 20;
            // 
            // com_domingo
            // 
            this.com_domingo.FormattingEnabled = true;
            this.com_domingo.Items.AddRange(new object[] {
            "Descanso"});
            this.com_domingo.Location = new System.Drawing.Point(65, 189);
            this.com_domingo.Name = "com_domingo";
            this.com_domingo.Size = new System.Drawing.Size(202, 21);
            this.com_domingo.TabIndex = 22;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(341, 184);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 23;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // col_saba
            // 
            this.col_saba.HeaderText = "Sábado";
            this.col_saba.Name = "col_saba";
            // 
            // col_domi
            // 
            this.col_domi.HeaderText = "Domingo";
            this.col_domi.Name = "col_domi";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(341, 147);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 24;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Data_superior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.com_domingo);
            this.Controls.Add(this.com_sabado);
            this.Controls.Add(this.com_viernes);
            this.Controls.Add(this.com_jueves);
            this.Controls.Add(this.com_miercoles);
            this.Controls.Add(this.com_martes);
            this.Controls.Add(this.com_lunes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_superior_1);
            this.Name = "Data_superior";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_superior_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_superior_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn collunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmier;
        private System.Windows.Forms.DataGridViewTextBoxColumn coljue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvier;
        private System.Windows.Forms.ComboBox com_lunes;
        private System.Windows.Forms.ComboBox com_martes;
        private System.Windows.Forms.ComboBox com_jueves;
        private System.Windows.Forms.ComboBox com_miercoles;
        private System.Windows.Forms.ComboBox com_sabado;
        private System.Windows.Forms.ComboBox com_viernes;
        private System.Windows.Forms.ComboBox com_domingo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saba;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_domi;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}