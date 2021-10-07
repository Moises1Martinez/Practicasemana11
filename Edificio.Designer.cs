
namespace Practicasemana11
{
    partial class Edificio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.textnombre = new MetroFramework.Controls.MetroTextBox();
            this.textdireccion = new MetroFramework.Controls.MetroTextBox();
            this.textcant = new MetroFramework.Controls.MetroTextBox();
            this.textrentados = new MetroFramework.Controls.MetroTextBox();
            this.btnregistrar = new MetroFramework.Controls.MetroButton();
            this.btncancelar = new MetroFramework.Controls.MetroButton();
            this.btnsalir = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de departamentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamentos rentados:";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // textnombre
            // 
            // 
            // 
            // 
            this.textnombre.CustomButton.Image = null;
            this.textnombre.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textnombre.CustomButton.Name = "";
            this.textnombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textnombre.CustomButton.TabIndex = 1;
            this.textnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textnombre.CustomButton.UseSelectable = true;
            this.textnombre.CustomButton.Visible = false;
            this.textnombre.Lines = new string[] {
        "Nombre"};
            this.textnombre.Location = new System.Drawing.Point(161, 80);
            this.textnombre.MaxLength = 32767;
            this.textnombre.Name = "textnombre";
            this.textnombre.PasswordChar = '\0';
            this.textnombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textnombre.SelectedText = "";
            this.textnombre.SelectionLength = 0;
            this.textnombre.SelectionStart = 0;
            this.textnombre.ShortcutsEnabled = true;
            this.textnombre.Size = new System.Drawing.Size(188, 23);
            this.textnombre.TabIndex = 5;
            this.textnombre.Text = "Nombre";
            this.textnombre.UseSelectable = true;
            this.textnombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textnombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textdireccion
            // 
            // 
            // 
            // 
            this.textdireccion.CustomButton.Image = null;
            this.textdireccion.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textdireccion.CustomButton.Name = "";
            this.textdireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textdireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textdireccion.CustomButton.TabIndex = 1;
            this.textdireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textdireccion.CustomButton.UseSelectable = true;
            this.textdireccion.CustomButton.Visible = false;
            this.textdireccion.Lines = new string[] {
        "Direccion"};
            this.textdireccion.Location = new System.Drawing.Point(161, 129);
            this.textdireccion.MaxLength = 32767;
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.PasswordChar = '\0';
            this.textdireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textdireccion.SelectedText = "";
            this.textdireccion.SelectionLength = 0;
            this.textdireccion.SelectionStart = 0;
            this.textdireccion.ShortcutsEnabled = true;
            this.textdireccion.Size = new System.Drawing.Size(188, 23);
            this.textdireccion.TabIndex = 6;
            this.textdireccion.Text = "Direccion";
            this.textdireccion.UseSelectable = true;
            this.textdireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textdireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textcant
            // 
            // 
            // 
            // 
            this.textcant.CustomButton.Image = null;
            this.textcant.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.textcant.CustomButton.Name = "";
            this.textcant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textcant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textcant.CustomButton.TabIndex = 1;
            this.textcant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textcant.CustomButton.UseSelectable = true;
            this.textcant.CustomButton.Visible = false;
            this.textcant.Lines = new string[] {
        "Cantidad de departamentos"};
            this.textcant.Location = new System.Drawing.Point(318, 190);
            this.textcant.MaxLength = 32767;
            this.textcant.Name = "textcant";
            this.textcant.PasswordChar = '\0';
            this.textcant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textcant.SelectedText = "";
            this.textcant.SelectionLength = 0;
            this.textcant.SelectionStart = 0;
            this.textcant.ShortcutsEnabled = true;
            this.textcant.Size = new System.Drawing.Size(203, 23);
            this.textcant.TabIndex = 7;
            this.textcant.Text = "Cantidad de departamentos";
            this.textcant.UseSelectable = true;
            this.textcant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textcant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textrentados
            // 
            // 
            // 
            // 
            this.textrentados.CustomButton.Image = null;
            this.textrentados.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.textrentados.CustomButton.Name = "";
            this.textrentados.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textrentados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textrentados.CustomButton.TabIndex = 1;
            this.textrentados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textrentados.CustomButton.UseSelectable = true;
            this.textrentados.CustomButton.Visible = false;
            this.textrentados.Lines = new string[] {
        "Departamentos rentados"};
            this.textrentados.Location = new System.Drawing.Point(289, 241);
            this.textrentados.MaxLength = 32767;
            this.textrentados.Name = "textrentados";
            this.textrentados.PasswordChar = '\0';
            this.textrentados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textrentados.SelectedText = "";
            this.textrentados.SelectionLength = 0;
            this.textrentados.SelectionStart = 0;
            this.textrentados.ShortcutsEnabled = true;
            this.textrentados.Size = new System.Drawing.Size(232, 23);
            this.textrentados.TabIndex = 8;
            this.textrentados.Text = "Departamentos rentados";
            this.textrentados.UseSelectable = true;
            this.textrentados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textrentados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(321, 304);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(104, 34);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Rgeristrar";
            this.btnregistrar.UseSelectable = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(478, 304);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 34);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseSelectable = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(838, 594);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 38);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1006, 49);
            this.label5.TabIndex = 12;
            this.label5.Text = "Registro de edificios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 660);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.textrentados);
            this.Controls.Add(this.textcant);
            this.Controls.Add(this.textdireccion);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edificio";
            this.Text = "Edificio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MetroFramework.Controls.MetroTextBox textnombre;
        private MetroFramework.Controls.MetroTextBox textdireccion;
        private MetroFramework.Controls.MetroTextBox textcant;
        private MetroFramework.Controls.MetroTextBox textrentados;
        private MetroFramework.Controls.MetroButton btnregistrar;
        private MetroFramework.Controls.MetroButton btncancelar;
        private MetroFramework.Controls.MetroButton btnsalir;
        private System.Windows.Forms.Label label5;
    }
}